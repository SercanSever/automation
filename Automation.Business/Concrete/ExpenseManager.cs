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
    public class ExpenseManager : IExpenseManager
    {
        IExpenseDal _expenseDal;

        public ExpenseManager(IExpenseDal expenseDal)
        {
            _expenseDal = expenseDal;
        }

        public void Add(Expense expense)
        {
            _expenseDal.Add(expense);
        }

        public List<Expense> GetAll()
        {
            return _expenseDal.GetAll();
        }

        public Expense GetById(int id)
        {
            return _expenseDal.Get(x => x.ExpenseId == id);
        }

        public void Update(Expense expense)
        {
            _expenseDal.Update(expense);
        }
    }
}
