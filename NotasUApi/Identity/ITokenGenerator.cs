using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NotasUApi.Identity
{
   public interface ITokenGenerator
    {
        string GenerateToken(string username);
    }
}
