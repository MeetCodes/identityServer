using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IdentityServer4.Models;

namespace meetCodes.IdentityServer.Config
{
    internal static class Scopes
    {
        internal static IEnumerable<Scope> GetScopes()
        {
            return new List<Scope>
            {
                new Scope
                {
                    Name = "api1",
                    Description = "My API"
                },

                StandardScopes.OfflineAccess,
                StandardScopes.Email,
                StandardScopes.Profile,
                StandardScopes.OpenId  
            };
        }
    }
}
