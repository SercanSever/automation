using Automation.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation.Business.Abstract
{
    public interface IInvoiceDetailManager
    {
        List<InvoiceDetail> GetAll();
        InvoiceDetail GetById(int id);
        void Add(InvoiceDetail invoiceDetail);
        void Update(InvoiceDetail invoiceDetail);
    }
}
