using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.CookiePolicy
{
    public class CookiePolicyOptions
    {
        public CookieBuilder ConsentCookie { get; set; } = new CookieBuilder()
        {
            Name = ".AspNet.Consent",
            Expiration = TimeSpan.FromDays(365 * 10),
            //IsEssential = true,
        };
    }
}
