using Automation.DataAccess.Context;
using Automation.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AutomationUI.Models
{
    public class DepartmentListViewModel
    {
        public List<Department> Departments { get; set; }
        public List<SelectListItem> GetDepartmentsListItems()
        {
            using (AutomationContext context = new AutomationContext())
            {
                var result = from d in context.Departments.Where(x=>x.IsActive==true)
                             select new SelectListItem
                             {
                                 Text = d.DepartmentName,
                                 Value = d.DepartmentId.ToString()
                             };
                return result.ToList();
            }
        }
    }
}