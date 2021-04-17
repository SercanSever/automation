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
    public class CustomerManager : ICustomerManager
    {
        private ICustomerDal _customerDal;

        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

        public void Add(Customer customer)
        {
            _customerDal.Add(customer);
        }

        public List<Customer> GetAll()
        {
            return _customerDal.GetAll();
        }
        public List<Customer> GetAllActives()
        {
            return _customerDal.GetAll(x => x.IsActive == true);
        }

        public Customer GetById(int id)
        {
            return _customerDal.Get(x => x.CustomerId == id);
        }

        public void Update(Customer customer)
        {
            _customerDal.Update(customer);
        }
    }
}
