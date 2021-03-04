using Automation.Business.Abstract;
using Automation.DataAccess.Abstract;
using Automation.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation.Business.Concrete
{
    public class InvoiceDetailManager : IInvoiceDetailManager
    {
        private IInvoiceDetailDal _invoiceDetailDal;

        public InvoiceDetailManager(IInvoiceDetailDal invoiceDetailDal)
        {
            _invoiceDetailDal = invoiceDetailDal;
        }

        public void Add(InvoiceDetail invoiceDetail)
        {
            _invoiceDetailDal.Add(invoiceDetail);
        }

        public List<InvoiceDetail> GetAll()
        {
            return _invoiceDetailDal.GetAll();
        }

        public InvoiceDetail GetById(int id)
        {
            return _invoiceDetailDal.Get(x => x.InvoiceContentId == id);
        }

        public void Update(InvoiceDetail invoiceDetail)
        {
            _invoiceDetailDal.Update(invoiceDetail);
        }
    }
}
