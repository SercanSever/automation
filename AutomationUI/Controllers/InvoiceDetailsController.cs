using Automation.Business.Abstract;
using AutomationUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AutomationUI.Controllers
{
    public class InvoiceDetailsController : Controller
    {
        private IInvoiceDetailManager _invoiceDetailManager;

        public InvoiceDetailsController(IInvoiceDetailManager invoiceDetailManager)
        {
            _invoiceDetailManager = invoiceDetailManager;
        }

        [HttpGet]
        public ActionResult Index()
        {
            var model = new InvoiceDetailListViewModel
            {
                InvoiceDetails = _invoiceDetailManager.GetAll()
            };
            return View(model);
        }
    }
}