﻿using System.Web;
using System.Web.Mvc;

namespace mvc_codigo_8_lista_jquery
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
