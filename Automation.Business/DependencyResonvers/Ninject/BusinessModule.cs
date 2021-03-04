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

            Bind<IProductManager>().To<ProductManager>();
            Bind<IProductDal>().To<ProductDal>();

            Bind<IDepartmentManager>().To<DepartmentManager>();
            Bind<IDepartmentDal>().To<DepartmentDal>();

            Bind<ICustomerManager>().To<CustomerManager>();
            Bind<ICustomerDal>().To<CustomerDal>();

            Bind<IEmployeeManager>().To<EmployeeManager>();
            Bind<IEmployeeDal>().To<EmployeeDal>();

            Bind<ISalesDetailManager>().To<SalesDetailManager>();
            Bind<ISalesDetailDal>().To<SalesDetailDal>();

            Bind<IExpenseManager>().To<ExpenseManager>();
            Bind<IExpenseDal>().To<ExpenseDal>();

            Bind<IInvoiceManager>().To<InvoiceManager>();
            Bind<IInvoiceDal>().To<InvoiceDal>();

            Bind<IInvoiceDetailManager>().To<InvoiceDetailManager>();
            Bind<IInvoiceDetailDal>().To<InvoiceDetailDal>();

        }
    }
}
