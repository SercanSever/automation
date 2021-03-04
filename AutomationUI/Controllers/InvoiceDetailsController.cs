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
    public class InvoiceDetailsController : Controller
    {
        private IInvoiceDetailManager _invoiceDetailManager;

        public InvoiceDetailsController(IInvoiceDetailManager invoiceDetailManager)
        {
            _invoiceDetailManager = invoiceDetailManager;
        }

        [HttpGet]
        public ActionResult Index(int id)
        {
            var model = new InvoiceDetailListViewModel
            {
                InvoiceDetails = _invoiceDetailManager.GetInvoiceDetailsByInvoiceId(id)
            };
            return View(model);
        }
        [HttpGet]
        public ActionResult AddInvoiceDetail()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddInvoiceDetail(InvoiceDetail invoiceDetail)
        {
            _invoiceDetailManager.Add(invoiceDetail);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult DeleteInvoice(int id)
        {
            var invoiceDetail = _invoiceDetailManager.GetById(id);
            _invoiceDetailManager.Update(invoiceDetail);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult UpdateInvoiceDetail(int id)
        {
            var invoiceDetail = _invoiceDetailManager.GetById(id);
            return View("UpdateInvoiceDetail", invoiceDetail);
        }
        [HttpPost]
        public ActionResult UpdateInvoiceDetail(InvoiceDetail invoiceDetail)
        {
            _invoiceDetailManager.Update(invoiceDetail);
            return RedirectToAction("Index");
        }
    }
}