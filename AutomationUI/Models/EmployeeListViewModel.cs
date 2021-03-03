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
    }
}