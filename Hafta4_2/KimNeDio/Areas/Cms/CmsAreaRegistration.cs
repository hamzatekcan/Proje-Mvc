﻿using System.Web.Mvc;

namespace KimNeDio.Areas.Cms
{
    public class CmsAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Cms";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Cms_default",
                "Cms/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional },
                new[] { "KimNeDio.Areas.Cms.Controllers" }
            );
        }
    }
}