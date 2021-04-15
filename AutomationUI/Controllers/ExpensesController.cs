using Automation.Business.Abstract;
using Automation.Entities.Concrete;
using AutomationUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AutomationUI.Controllers
{
    public class ExpensesController : Controller
    {
        IExpenseManager _expenseManager;

        public ExpensesController(IExpenseManager expenseManager)
        {
            _expenseManager = expenseManager;
        }

        [HttpGet]
        public ActionResult Index()
        {
            var model = new ExpenseListViewModel
            {
                Expenses = _expenseManager.GetAll()
            };
            return View(model);
        }
        [HttpGet]
        public ActionResult AddExpense()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddExpense(Expense expense)
        {
            expense.ExpenseDate = DateTime.Now;
            _expenseManager.Add(expense);
            return RedirectToAction("AddExpense");
        }
        [HttpGet]
        public ActionResult UpdateExpense(int id)
        {
            var expense = _expenseManager.GetById(id);
            return View("UpdateExpense", expense);
        }
        [HttpPost]
        public ActionResult UpdateExpense(Expense expense)
        {
            expense.ExpenseDate = DateTime.Now;
            _expenseManager.Update(expense);
            return RedirectToAction("Index");
        }

    }
}