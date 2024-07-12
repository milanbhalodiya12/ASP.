using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication4
{
    public static class CustomHelper
    {
        public static IHtmlString Mytag(string val , string alt)
        {
            string t = "<img src = '"+val+"' alt = '"+alt+"'>";
            return new MvcHtmlString(t);
        }
    }
}