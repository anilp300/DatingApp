using System;
using API.Entities;

namespace API.Interfaces
{
    public interface ITokenService
    {
        string CreateToken(AppUser user)
        {
             throw new NotImplementedException();
        }

        // internal string CreateTokenUser()
        // {
        //     throw new NotImplementedException();
        // }
    }
}