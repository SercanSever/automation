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
    public class InvoiceManager : IInvoiceManager
    {
        private IInvoiceDal _invoiceDal;

        public InvoiceManager(IInvoiceDal invoiceDal)
        {
            _invoiceDal = invoiceDal;
        }

        public void Add(Invoice invoice)
        {
            _invoiceDal.Add(invoice);
        }

        public List<Invoice> GetAll()
        {
            return _invoiceDal.GetAll();
        }

        public Invoice GetById(int id)
        {
            return _invoiceDal.Get(x => x.InvoiceId == id);
        }

        public void Update(Invoice invoice)
        {
            _invoiceDal.Update(invoice);
        }
    }
}
