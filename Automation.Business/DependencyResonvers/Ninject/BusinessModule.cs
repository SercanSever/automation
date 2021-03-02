using Automation.Business.Abstract;
using Automation.Business.Concrete;
using Automation.DataAccess.Abstract;
using Automation.DataAccess.Concrete;
using Automation.DataAccess.Context;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation.Business.DependencyResonvers.Ninject
{
    public class BusinessModule : NinjectModule
    {
        public override void Load()
        {
            Bind<DbContext>().To<AutomationContext>();

            Bind<ICategoryManager>().To<CategoryManager>();
            Bind<ICategoryDal>().To<CategoryDal>();

            
        }
    }
}
