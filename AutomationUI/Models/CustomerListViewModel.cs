using Automation.DataAccess.Context;
using Automation.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AutomationUI.Models
{
    public class CustomerListViewModel
    {
        public List<Customer> Customers { get; set; }
        public List<SelectListItem> GetCustomerListItems()
        {
            using (AutomationContext context = new AutomationContext())
            {
                var result = from c in context.Customers.Where(c=>c.IsActive==true)
                             select new SelectListItem
                             {
                                 Text = c.CustomerName,
                                 Value = c.CustomerId.ToString()
                             };
                return result.ToList();
            }
        }
    }
}