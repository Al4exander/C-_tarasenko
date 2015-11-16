using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Task_2.Views.my;

namespace Task_2.Controllers
{
    public class myController : Controller
    {
        // GET: my
        public ActionResult task131()
        {
            List<string> str = new List<string>();

            str.Add("<li>Строка№1</li>");
            str.Add("<li>Строка№2</li>");
            str.Add("<li>Строка№3</li>");

            return new AddHTML(str);
        }

        public ActionResult task132()
        {
            List<string> str = new List<string>();

            str.Add("<li>1</li>");
            str.Add("<li>Два</li>");
            str.Add("<li>Three</li>");
            str.Add("<li>Чотири</li>");

            return new AddHTML(str);
        }

        public ActionResult task133()
        {
            List<string> str = new List<string>();

            str.Add("<li>Кот</li>");
            str.Add("<li>Собака</li>");

            return new AddHTML(str);
        }
    }
}