﻿using IdentityServer3.Core;
using IdentityServer3.Core.Services.InMemory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;

namespace SSODemo
{
    public static class Users
    {
        public static List<InMemoryUser> Get() => new List<InMemoryUser> {
            new InMemoryUser {
                Subject = "1",
                Username = "Scott Brady",
                Password = "Password123!",
                Claims = new List<Claim> {
                    new Claim(Constants.ClaimTypes.GivenName, "Scott"),
                    new Claim(Constants.ClaimTypes.FamilyName, "Brady"),
                    new Claim(Constants.ClaimTypes.Email, "info@scottbrady91.com"),
                    new Claim(Constants.ClaimTypes.Role, "Badmin")
                }
            }
        };
    }
}