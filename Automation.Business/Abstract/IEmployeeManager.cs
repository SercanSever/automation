using Automation.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation.Business.Abstract
{
    public interface IEmployeeManager
    {
        List<Employee> GetAll();
        Employee GetById(int id);
        void Add(Employee employee);
        void Update(Employee employee);
        List<Employee> GetDepartmentById(int id);
        string GetEmployeeNameById(int id);
    }
}
