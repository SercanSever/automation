using Automation.DataAccess.Abstract;
using Automation.DataAccess.Context;
using Automation.Entities.Concrete;
using Core.DataAccess.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Automation.DataAccess.Concrete
{
    public class CategoryDal : EfEntityRepositoryBase<Category, AutomationContext>, ICategoryDal
    {
        public List<SelectListItem> GetCategoriesListItems()
        {
            using (AutomationContext context = new AutomationContext())
            {
                var result = from c in context.Categories
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
