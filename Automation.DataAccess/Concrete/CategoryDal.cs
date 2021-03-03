using Automation.DataAccess.Abstract;
using Automation.DataAccess.Context;
using Automation.Entities.Concrete;
using Core.DataAccess.EntityFramework;
using System.Collections.Generic;
using System.Linq;

namespace Automation.DataAccess.Concrete
{
    public class CategoryDal : EfEntityRepositoryBase<Category, AutomationContext>, ICategoryDal
    {
    }
}
