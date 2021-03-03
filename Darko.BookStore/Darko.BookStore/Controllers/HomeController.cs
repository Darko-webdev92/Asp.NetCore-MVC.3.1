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
        public string Index()
        {
            return "Dare";
        }
    }
}
