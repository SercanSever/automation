using Automation.Business.Abstract;
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
    }
}