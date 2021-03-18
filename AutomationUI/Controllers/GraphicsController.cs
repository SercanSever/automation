using Automation.Business.Abstract;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;

namespace AutomationUI.Controllers
{
    public class GraphicsController : Controller
    {
        IProductManager _productManager;

        public GraphicsController(IProductManager productManager)
        {
            _productManager = productManager;
        }

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Graphic()
        {
            var graphic = new Chart(600, 600);
            graphic.AddTitle("Kategori - Stok Sayısı");
            graphic.AddLegend(title: "Veriler");
            graphic.AddSeries(xValue: new[] { "Giyim", "Beyaz Eşya", "Spor" }, yValues: new[] { "200", "333", "432" });
            graphic.Write();
            return File(graphic.ToWebImage().GetBytes(), "image/jpeg");
        }
        [HttpGet]
        public ActionResult GraphicList()
        {
            var xValues = new ArrayList();
            var yValues = new ArrayList();
            var products = _productManager.GetAll();
            products.ToList().ForEach(x => xValues.Add(x.ProductName));
            products.ToList().ForEach(x => yValues.Add(x.StockStatus));
            var graphic = new Chart(width: 500, height: 500);
            graphic.AddTitle("Stoklar").AddSeries(chartType: "Column", name: "Stok", xValue: xValues, yValues: yValues);
            return File(graphic.ToWebImage().GetBytes(), "image/jpeg");
        }
    }
}