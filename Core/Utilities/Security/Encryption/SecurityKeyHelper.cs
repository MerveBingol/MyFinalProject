using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Security.Encryption
{
   public  class SecurityKeyHelper
    {
        // diyoruz ki ben sana bir SecurityKey vereceğim sen de bana simetrik bir securityKey oluştur.
        public static SecurityKey CreateSecurityKey(string securityKey)
        {
            return new SymmetricSecurityKey(Encoding.UTF8.GetBytes(securityKey));
        
        
        }
    }
}
