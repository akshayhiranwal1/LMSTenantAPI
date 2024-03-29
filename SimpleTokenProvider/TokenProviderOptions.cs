﻿using System;
using System.Threading.Tasks;
using Microsoft.IdentityModel.Tokens;
using System.Collections.Generic;

namespace BookRight.Api.SimpleTokenProvider
{

    /// <summary>
    /// Provides options for <see cref="AuthUser"/>.
    /// </summary>
    public class AuthUser 
    {
        /// <summary>
        /// 
        /// </summary>
        public bool isAuth { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int uid { get; set; }
        public int cmpid { get; set; }
        public int ulevel { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public string countryName { get; set; }
        public string domainName { get; set; }
        public int usr_level { get; set; }
        public int roleId { get; set; }
        public bool status { get; set; }
        public bool isapprover { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<string> roles { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string ref1 { get; set; }
    }
    /// <summary>
    /// Provides options for <see cref="TokenProviderMiddleware"/>.
    /// </summary>
    public class TokenProviderOptions
    {
        /// <summary>
        /// The relative request path to listen on.
        /// </summary>
        /// <remarks>The default path is <c>/token</c>.</remarks>
        public string Path { get; set; } = "/token";

        /// <summary>
        ///  The Issuer (iss) claim for generated tokens.
        /// </summary>
        public string Issuer { get; set; }

        /// <summary>
        /// The Audience (aud) claim for the generated tokens.
        /// </summary>
        public string Audience { get; set; }

        /// <summary>
        /// The expiration time for the generated tokens.
        /// </summary>
        /// <remarks>The default is 8 hour (28800 seconds).</remarks>
        public TimeSpan Expiration { get; set; } = TimeSpan.FromHours(8);

        /// <summary>
        /// The signing key to use when generating tokens.
        /// </summary>
        public SigningCredentials SigningCredentials { get; set; }

        /// <summary>
        /// Resolves a user identity given a username and password.
        /// </summary>
        public Func<string, string,string, Task<AuthUser>> IdentityResolver { get; set; }

        /// <summary>
        /// Generates a random value (nonce) for each generated token.
        /// </summary>
        /// <remarks>The default nonce is a random GUID.</remarks>
        public Func<Task<string>> NonceGenerator { get; set; }
            = new Func<Task<string>>(() => Task.FromResult(Guid.NewGuid().ToString()));
    }
}