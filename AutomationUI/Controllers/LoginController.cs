using Automation.Business.Abstract;
using Automation.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace AutomationUI.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        IAdminManager _adminManager;

        public LoginController(IAdminManager adminManager)
        {
            _adminManager = adminManager;
        }

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddAdmin(Admin admin)
        {
            if (!ModelState.IsValid)
            {
                return View("Index");
            }
            _adminManager.Add(admin);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult AdminLogin()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AdminLogin(Admin admin)
        {
            if (!ModelState.IsValid)
            {
                return View("AdminLogin");
            }
            var model = _adminManager.GetByNameAndPassword(admin);
            if (model.AdminName == admin.AdminName && model.AdminPassword == admin.AdminPassword)
            {
                FormsAuthentication.SetAuthCookie(model.AdminName, false);
                Session["AdminName"] = admin.AdminName.ToString();
                return RedirectToAction("Index", "Boards");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index");
        }

    }
}