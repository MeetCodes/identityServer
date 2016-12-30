using System.Collections.Generic;
using IdentityServer4.Models;

namespace meetCodes.IdentityServer.Config
{
    internal class Clients
    {
        internal static IEnumerable<Client> GetClients()
        {
            return new List<Client>
            {
                new Client
                {
                    ClientId = "client",

                    // no interactive user, use the clientid/secret for authentication
                    AllowedGrantTypes = GrantTypes.ClientCredentials,

                    // secret for authentication
                    ClientSecrets =
                    {
                        new Secret("secret".Sha256())
                    },

                    // scopes that client has access to
                    AllowedScopes = {"api1"}
                },
                new Client
                {
                    ClientId = "faceBook",
                    AllowedGrantTypes = GrantTypes.Implicit,
                    ClientSecrets =
                    {
                        new Secret("secret".Sha256())
                    },
                    RedirectUris = {"http://localhost:64640/signin-facebook"},
                    PostLogoutRedirectUris = {"http://localhost:5002"},
                    AllowedScopes =
                    {
                        StandardScopes.OpenId.Name,
                        StandardScopes.Profile.Name,
                        StandardScopes.OfflineAccess.Name,
                        "api1"
                    }
                },
                 new Client
                {
                    ClientId = "mvc",
                     ClientName = "MVC Hybrid Client",
                    AllowedGrantTypes = GrantTypes.HybridAndClientCredentials,
                    ClientSecrets =
                    {
                        new Secret("secret".Sha256())
                    },
                    RedirectUris = {"http://localhost:64640/signin-facebook","http://localhost:21402/signin-oidc","https://localhost:21402/signin-oidc",
                                   "https://www.google.com"},
                    PostLogoutRedirectUris = {"http://localhost:5002"},
                    AllowedScopes =
                    {
                        StandardScopes.OpenId.Name,
                        StandardScopes.Profile.Name,
                        StandardScopes.OfflineAccess.Name,
                        StandardScopes.Email.Name,
                        "api1"
                    }
                 }
            };
        }
    }
}
