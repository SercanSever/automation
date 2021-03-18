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
        IProductManager _productManager;

        public SalesDetailManager(ISalesDetailDal salesDetailDal, IProductManager productManager)
        {
            _salesDetailDal = salesDetailDal;
            _productManager = productManager;
        }

        public void Add(SalesDetail salesDetail)
        {
            DropOffStock(salesDetail);
            SalasDetailDate(salesDetail);
            MultiplyQuantityAndPrice(salesDetail);

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

        public List<SalesDetail> GetSalesByCustomerId(int id)
        {
            return _salesDetailDal.GetAll(x => x.CustomerId == id);
        }

        public List<SalesDetail> GetSalesByEmployeeId(int id)
        {
            return _salesDetailDal.GetAll(x => x.EmployeeId == id);
        }

        public void Update(SalesDetail salesDetail)
        {
            SalasDetailDate(salesDetail);
            MultiplyQuantityAndPrice(salesDetail);
            _salesDetailDal.Update(salesDetail);
        }




        private void MultiplyQuantityAndPrice(SalesDetail salesDetail)
        {
            salesDetail.SalesDetailTotal = salesDetail.SalesDetailPrice * salesDetail.SalesDetailQuantity;
        }
        private void SalasDetailDate(SalesDetail salesDetail)
        {
            salesDetail.SalesDetailDate = DateTime.Now;
        }
        private void DropOffStock(SalesDetail salesDetail)
        {
            var product = _productManager.GetById(salesDetail.ProductId);
            if (product.UnitInStock >= 0)
            {
                product.UnitInStock -= salesDetail.SalesDetailQuantity;
                _productManager.Update(product);
            }
        }
    }
}
