using Automation.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Automation.Entities.Concrete
{
    public class SalesDetail : IEntity
    {
        [Key]
        public int SalesDetailId { get; set; }
        public DateTime SalesDetailDate { get; set; }
        public int SalesDetailQuantity { get; set; }
        public decimal SalesDetailPrice { get; set; }
        public decimal SalesDetailTotal { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }

    }
}
