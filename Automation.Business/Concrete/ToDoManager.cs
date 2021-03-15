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
    public class ToDoManager : IToDoManager
    {
        IToDoDal _toDoDal;

        public ToDoManager(IToDoDal toDoDal)
        {
            _toDoDal = toDoDal;
        }

        public void Add(ToDo toDo)
        {
            _toDoDal.Add(toDo);
        }

        public List<ToDo> GetAll()
        {
            return _toDoDal.GetAll();
        }

        public ToDo GetById(int id)
        {
            return _toDoDal.Get(x => x.Id == id);
        }

        public void Update(ToDo toDo)
        {
            _toDoDal.Update(toDo);
        }
    }
}
