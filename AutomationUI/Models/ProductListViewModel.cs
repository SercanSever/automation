using Automation.Entities.Concrete;
using Automation.Entities.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AutomationUI.Models
{
    public class ProductListViewModel
    {
        public List<Product> Products { get; set; }
        public List<ProductDetailDto> GetProductDetails { get; internal set; }
    }
}