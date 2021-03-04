using Automation.DataAccess.Abstract;
using Automation.DataAccess.Context;
using Automation.Entities.Concrete;
using Core.DataAccess.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation.DataAccess.Concrete
{
    public class InvoiceDetailDal : EfEntityRepositoryBase<InvoiceDetail, AutomationContext>, IInvoiceDetailDal
    {
    }
}
