using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mywebsite.Models;

namespace Mywebsite.Controllers
{
    public class ContactUsController : Controller
    {
        // GET: ContactUs
        public ActionResult Index()
        {
            return View();
            
        }
        [HttpPost]
        public ActionResult Submit()
        {
            return View();

        }
    }
}