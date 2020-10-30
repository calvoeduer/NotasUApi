using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using NotasUApi.Identity;
using NotasUApi.Model;
using NotasUApi.Model.ViewModel;

namespace NotasUApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        readonly UserManager<ApplicationUser> _userManager;
        readonly SignInManager<ApplicationUser> _signInManager;
        readonly IMapper _mapper;
        readonly ITokenGenerator _tokenGenerator;


        public UsersController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, IMapper mapper, ITokenGenerator tokenGenerator)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _mapper = mapper;
            _tokenGenerator = tokenGenerator;
        }

        private void SetIdentityResultErrors(IdentityResult identityResult)
        {
            foreach (IdentityError error in identityResult.Errors)
                ModelState.AddModelError(error.Code, error.Description);
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<ActionResult<ApplicationUserViewModel>> PostUser([FromBody] ApplicationUserInputModel userInputModel)
        {
            ApplicationUser user = _mapper.Map<ApplicationUser>(userInputModel);

            IdentityResult result = await _userManager.CreateAsync(user, userInputModel.Password);
            if (!result.Succeeded)
            {
                SetIdentityResultErrors(result);
                return BadRequest(new ValidationProblemDetails(ModelState)
                {
                    Status = StatusCodes.Status400BadRequest
                });
            }

            return GenerateAuthenticateUser(user);
        }

        private ActionResult<ApplicationUserViewModel> GenerateAuthenticateUser(ApplicationUser user)
        {
            ApplicationUserViewModel userViewModel = _mapper.Map<ApplicationUserViewModel>(user);

            userViewModel.Token = _tokenGenerator.GenerateToken(user.UserName);

            return userViewModel;
        }

        [AllowAnonymous]
        [HttpPost("[action]")]
        public async Task<ActionResult<ApplicationUserViewModel>> Login([FromBody] LoginRequest loginRequest)
        {
            ApplicationUser user = await _userManager.FindByNameAsync(loginRequest.UsernameOrEmail);
            if (user is null)
                user = await _userManager.FindByEmailAsync(loginRequest.UsernameOrEmail);

            if (user is null)
                return NotFound($"User with username or email = {loginRequest.UsernameOrEmail} does no exists.");

            Microsoft.AspNetCore.Identity.SignInResult result = await _signInManager.PasswordSignInAsync(user, loginRequest.Password, false, false);

            if (!result.Succeeded)
                return BadRequest("Incorrect Password");

            return GenerateAuthenticateUser(user);
        }
    }
}
