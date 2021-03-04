using Automation.Business.Abstract;
using Automation.Entities.Concrete;
using AutomationUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AutomationUI.Controllers
{
    public class InviocesController : Controller
    {
        private IInvoiceManager _invoiceManager;

        public InviocesController(IInvoiceManager invoiceManager)
        {
            _invoiceManager = invoiceManager;
        }

        [HttpGet]
        public ActionResult Index()
        {
            var model = new InvoiceListViewModel
            {
                Invoices = _invoiceManager.GetAll()
            };
            return View(model);
        }
        [HttpGet]
        public ActionResult AddInvoice()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddInvoice(Invoice invoice)
        {
            _invoiceManager.Add(invoice);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult DeleteInvoice(int id)
        {
            var invoice = _invoiceManager.GetById(id);
            invoice.IsActive = !invoice.IsActive;
            _invoiceManager.Update(invoice);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult UpdateInvoice(int id)
        {
            var invoice = _invoiceManager.GetById(id);
            return View("UpdateInvoice", invoice);
        }
        [HttpPost]
        public ActionResult UpdateInvoice(Invoice invoice)
        {
            _invoiceManager.Update(invoice);
            return RedirectToAction("Index");
        }
    }
}