using Automation.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation.Business.Abstract
{
    public interface IDepartmentManager
    {
        List<Department> GetAll();
        Department GetById(int id);
        void Add(Department department);
        void Update(Department department);
    }
}
