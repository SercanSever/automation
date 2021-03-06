using Automation.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation.Business.Abstract
{
    public interface IAdminManager
    {
        Admin GetById(int id);
        void Add(Admin admin);
        void Update(Admin admin);
        Admin GetByNameAndPassword(Admin admin);
    }
}
