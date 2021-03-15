using Automation.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation.Business.Abstract
{
    public interface IToDoManager
    {
        List<ToDo> GetAll();
        ToDo GetById(int id);
        void Add(ToDo toDo);
        void Update(ToDo toDo);
    }
}
