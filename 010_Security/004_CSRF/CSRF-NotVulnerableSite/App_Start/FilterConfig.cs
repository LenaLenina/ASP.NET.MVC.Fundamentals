﻿using System.Web;
using System.Web.Mvc;

namespace CSRF_NotVulnerableSite
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}