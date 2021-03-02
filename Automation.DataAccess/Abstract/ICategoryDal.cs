using Automation.Entities.Concrete;
using Core.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Automation.DataAccess.Abstract
{
    public interface ICategoryDal : IEntityRepository<Category>
    {
        List<SelectListItem> GetCategoriesListItems();
    }
}
