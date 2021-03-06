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
    public class AdminManager : IAdminManager
    {
        IAdminDal _adminDal;

        public AdminManager(IAdminDal adminDal)
        {
            _adminDal = adminDal;
        }

        public void Add(Admin admin)
        {
            _adminDal.Add(admin);
        }

        public Admin GetById(int id)
        {
            return _adminDal.Get(x => x.AdminId == id);
        }

        public Admin GetByNameAndPassword(Admin admin)
        {
            return _adminDal.GetAll(x => x.AdminName == admin.AdminName).Where(x => x.AdminPassword == admin.AdminPassword).FirstOrDefault();
        }

        public void Update(Admin admin)
        {
            _adminDal.Update(admin);
        }
    }
}
