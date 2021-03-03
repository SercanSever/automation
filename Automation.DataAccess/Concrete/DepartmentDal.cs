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
    public class DepartmentDal : EfEntityRepositoryBase<Department, AutomationContext>, IDepartmentDal
    {
    }
}
