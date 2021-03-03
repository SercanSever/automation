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
    public class EmployeeManager : IEmployeeManager
    {
        IEmployeeDal _employeeDal;

        public EmployeeManager(IEmployeeDal employeeDal)
        {
            _employeeDal = employeeDal;
        }

        public void Add(Employee employee)
        {
            _employeeDal.Add(employee);
        }

        public List<Employee> GetAll()
        {
            return _employeeDal.GetAll();
        }

        public List<Employee> GetDepartmentById(int id)
        {
            return _employeeDal.GetAll(x => x.DepartmentId == id);
        }

        public Employee GetById(int id)
        {
            return _employeeDal.Get(x => x.EmployeeId == id);
        }

        public void Update(Employee employee)
        {
            _employeeDal.Update(employee);
        }

        public string GetEmployeeNameById(int id)
        {
            return _employeeDal.GetAll(x => x.EmployeeId == id).Select(y => y.EmployeeName + " " + y.EmployeeSurname).FirstOrDefault();
        }
    }
}
