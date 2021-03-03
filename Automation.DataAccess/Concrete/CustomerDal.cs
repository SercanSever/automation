using Automation.DataAccess.Abstract;
using Automation.DataAccess.Context;
using Automation.Entities.Concrete;
using Core.DataAccess.EntityFramework;

namespace Automation.DataAccess.Concrete
{
    public class CustomerDal : EfEntityRepositoryBase<Customer, AutomationContext>, ICustomerDal
    {
    }
}
