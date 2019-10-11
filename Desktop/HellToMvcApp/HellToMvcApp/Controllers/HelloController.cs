using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HellToMvcApp.Controllers
{
    public class HelloController : Controller
    {
        public ActionResult Fun()
        {
            return Content("Fun calling ");
        }
    }
}