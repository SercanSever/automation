using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AutomationUI.Controllers
{
    public class BoardsController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
    }
}