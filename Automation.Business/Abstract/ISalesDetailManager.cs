using Automation.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation.Business.Abstract
{
    public interface ISalesDetailManager
    {
        List<SalesDetail> GetAll();
        SalesDetail GetById(int id);
        void Add(SalesDetail salesDetail);
        void Update(SalesDetail salesDetail);
        List<SalesDetail> GetSalesByEmployeeId(int id);
    }
}
