using Automation.DataAccess.Context;
using Automation.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AutomationUI.Models
{
    public class CategoryListViewModel
    {
        public List<Category> Categories { get; set; }
        public List<SelectListItem> GetCategoriesListItems()
        {
            using (AutomationContext context = new AutomationContext())
            {
                var result = from c in context.Categories.Where(c => c.IsActive == true)
                             select new SelectListItem
                             {
                                 Text = c.CategoryName,
                                 Value = c.CategoryId.ToString()
                             };
                return result.ToList();
            }
        }
    }
}