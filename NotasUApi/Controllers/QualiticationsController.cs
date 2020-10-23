using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NotasUApi.Data;

namespace NotasUApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QualiticationsController : ControllerBase
    {
        private readonly AplicationDbContext dbContext;

        public QualiticationsController()
        {

        }
    }
}
