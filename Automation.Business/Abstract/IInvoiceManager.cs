using Automation.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation.Business.Abstract
{
    public interface IInvoiceManager
    {
        List<Invoice> GetAll();
        Invoice GetById(int id);
        void Add(Invoice invoice);
        void Update(Invoice invoice);
    }
}
