using Automation.DataAccess.Context;
using Automation.Entities.Concrete;
using Automation.Entities.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AutomationUI.Models
{
    public class ProductListViewModel
    {
        public List<Product> Products { get; set; }
        public List<ProductDetailDto> GetProductDetails { get; internal set; }
        public List<SelectListItem> GetProductNameListItems()
        {
            using (AutomationContext context = new AutomationContext())
            {
                var result = from p in context.Products.Where(p=>p.IsActive==true)
                             select new SelectListItem
                             {
                                 Text = p.ProductName,
                                 Value = p.ProductId.ToString()
                             };
                return result.ToList();
            }
        }
        public List<SelectListItem> GetBrandListItems()
        {
            using (AutomationContext context = new AutomationContext())
            {
                var result = from p in context.Products.Where(p => p.IsActive == true)
                             select new SelectListItem
                             {
                                 Text = p.Brand,
                                 Value = p.ProductId.ToString()
                             };
                return result.ToList();
            }
        }
    }
}