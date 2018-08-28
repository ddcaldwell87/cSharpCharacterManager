using CharacterManager.Data;
using CharacterManager.Models.CharacterModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CharacterManager.WebMVC.Helpers
{
    public static class HtmlHelperExtensions
    {
        public static string CurrentViewName(this HtmlHelper html)
        {
            return System.IO.Path.GetFileNameWithoutExtension(
               ((RazorView)html.ViewContext.View).ViewPath
           );
        }

        public static string CurrentController(this HtmlHelper html)
        {
            return System.IO.Path.GetFileNameWithoutExtension(
                (html.ViewContext.Controller.GetType().Name));
        }
    }
}