using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace myMVC.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public string Index(string id,string name)
        {
            return "Id=" + id+"Name="+name;
        }

        public String GetMvcVersion()
        {
            return typeof(Controller).Assembly.GetName().Version.ToString();
        }

        public string GetMethod()
        {
            return "Getmethod call";
        }

    }
}
