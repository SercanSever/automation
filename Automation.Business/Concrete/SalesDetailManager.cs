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
    public class SalesDetailManager : ISalesDetailManager
    {
        ISalesDetailDal _salesDetailDal;

        public SalesDetailManager(ISalesDetailDal salesDetailDal)
        {
            _salesDetailDal = salesDetailDal;
        }

        public void Add(SalesDetail salesDetail)
        {
            _salesDetailDal.Add(salesDetail);
        }

        public List<SalesDetail> GetAll()
        {
            return _salesDetailDal.GetAll();
        }

        public SalesDetail GetById(int id)
        {
            return _salesDetailDal.Get(x => x.SalesDetailId == id);
        }

        public List<SalesDetail> GetSalesByEmployeeId(int id)
        {
            return _salesDetailDal.GetAll(x => x.EmployeeId == id);
        }

        public void Update(SalesDetail salesDetail)
        {
            _salesDetailDal.Update(salesDetail);
        }
    }
}
