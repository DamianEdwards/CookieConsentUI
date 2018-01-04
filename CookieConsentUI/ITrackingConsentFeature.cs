using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CookieConsentUI
{
    public interface ITrackingConsentFeature
    {
        bool CanTrack { get; }
    }

    internal class TrackingConsentFeature : ITrackingConsentFeature
    {
        private readonly HttpContext _context;

        public TrackingConsentFeature(HttpContext context)
        {
            _context = context;
        }

        public bool CanTrack
        {
            get
            {
                var cookie = _context.Request.Cookies[".AspNet.Consent"];
                var hasConsent = string.Equals(cookie, "yes", StringComparison.Ordinal);
                return hasConsent;
            }
        }
    }
}
