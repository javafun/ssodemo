using IdentityServer3.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SSODemo
{
    public static class Scopes
    {
        public static IEnumerable<Scope> Get() => new List<Scope> {
            StandardScopes.OpenId,
            StandardScopes.Profile,
            StandardScopes.Email,
            StandardScopes.Roles,
            StandardScopes.OfflineAccess
        };
    }
}