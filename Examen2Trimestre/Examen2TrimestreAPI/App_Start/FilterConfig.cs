﻿using System.Web;
using System.Web.Mvc;

namespace Examen2TrimestreAPI
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}