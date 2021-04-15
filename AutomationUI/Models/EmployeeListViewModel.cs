using Automation.DataAccess.Context;
using Automation.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AutomationUI.Models
{
    public class EmployeeListViewModel
    {
        public List<Employee> Employees { get; set; }
        public List<SelectListItem> GetEmployeeListItems()
        {
            using (AutomationContext context = new AutomationContext())
            {
                var result = from e in context.Employees.Where(e => e.IsActive == true)
                             select new SelectListItem
                             {
                                 Text = e.EmployeeName,
                                 Value = e.EmployeeId.ToString()
                             };
                return result.ToList();
            }
        }
        public List<SelectListItem> GetRoles()
        {
            using (AutomationContext context = new AutomationContext())
            {
                var result = from r in context.Roles
                             select new SelectListItem
                             {
                                 Text = r.RoleName,
                                 Value = r.RoleId.ToString()
                             };
                return result.ToList();
            }
        }
    }
}