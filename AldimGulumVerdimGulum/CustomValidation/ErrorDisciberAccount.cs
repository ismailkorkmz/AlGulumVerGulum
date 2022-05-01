using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AldimGulumVerdimGulum.CustomValidation
{
    public class ErrorDisciberAccount: IdentityErrorDescriber
    {
        public override IdentityError PasswordRequiresLower()
        {
            var result = new IdentityError();
            result.Code = "murat";
            result.Description = "Küçük Harf Zorunlu";
            return result;
        }
    }
}
