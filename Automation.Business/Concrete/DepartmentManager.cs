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
    public class DepartmentManager : IDepartmentManager
    {
        private IDepartmentDal _departmentDal;

        public DepartmentManager(IDepartmentDal departmentDal)
        {
            _departmentDal = departmentDal;
        }

        public void Add(Department department)
        {
            _departmentDal.Add(department);
        }

        public List<Department> GetAll()
        {
            return _departmentDal.GetAll();
        }

        public Department GetById(int id)
        {
            return _departmentDal.Get(x => x.DepartmentId == id);
        }

        public void Update(Department department)
        {
            _departmentDal.Update(department);
        }
    }
}
