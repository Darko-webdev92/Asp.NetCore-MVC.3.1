using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Darko.BookStore.Controllers
{
    public class HomeController : Controller
    {

        // This method is called action method
        public ViewResult Index()
        {
            //  var obj = new { id = 1, name = "Darko" };
            // return View("TempView/DareTemp.cshtml");
            return View();
        }

        public ViewResult АboutUs()
        {
            return View();
        }

        public ViewResult ContactUs()
        {
            return View();
        }
    }
}
