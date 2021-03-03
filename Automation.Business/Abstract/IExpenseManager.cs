using Automation.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation.Business.Abstract
{
    public interface IExpenseManager
    {
        List<Expense> GetAll();
        Expense GetById(int id);
        void Add(Expense expense);
        void Update(Expense expense);
    }
}
