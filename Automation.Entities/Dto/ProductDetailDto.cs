using Automation.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation.Entities.Dto
{
    public class ProductDetailDto : IDto
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string CategoryName { get; set; }
        public string Brand { get; set; }
        public int UnitInStock { get; set; }
        public decimal UnitPrice { get; set; }
        public string ProductImage { get; set; }
        public bool StockStatus { get; set; }
        public bool IsActive { get; set; }
    }
}
