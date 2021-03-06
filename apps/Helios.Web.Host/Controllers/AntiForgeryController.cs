﻿using Microsoft.AspNetCore.Antiforgery;

namespace Helios.Web.Controllers
{
    public class AntiForgeryController : HeliosZeroControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
