using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace Task_2.Views.my
{
    public class AddHTML : ActionResult
    {
        private List<string> forHtml;

        public AddHTML(List<string> forHtml)
        {
            this.forHtml = forHtml;
        }

        public override void ExecuteResult(ControllerContext context)
        {
            string fullHtmlCode = "<!DOCTYPE html><html><head>";
         fullHtmlCode += "<title>Главная страница</title>";
         fullHtmlCode += "<meta charset = utf-8 />";
         fullHtmlCode += "</head> <ol>";
            foreach(string str in forHtml)
            {
               fullHtmlCode += str;
            }
         fullHtmlCode += "</ol></html>";
         context.HttpContext.Response.Write(fullHtmlCode); 
        } 
    } 
}

        