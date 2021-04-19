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
    public class CategoriesController : Controller
    {
        ICategoryManager _categoryManager;
        public CategoriesController(ICategoryManager categoryManager)
        {
            _categoryManager = categoryManager;
        }

        [HttpGet]
        public ActionResult Index()
        {
            var model = new CategoryListViewModel
            {
                Categories = _categoryManager.GetAll()
            };
            return View(model);
        }
        [HttpGet]
        public ActionResult AddCategory()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddCategory(Category category)
        {
            if (!ModelState.IsValid)
            {
                return View("AddCategory");
            }
            _categoryManager.Add(category);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult DeleteCategory(int id)
        {
            var category = _categoryManager.GetById(id);
            category.IsActive = !category.IsActive;
            _categoryManager.Update(category);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult UpdateCategory(int id)
        {
            var category = _categoryManager.GetById(id);
            return View("UpdateCategory", category);
        }
        [HttpPost]
        public ActionResult UpdateCategory(Category category)
        {
            if (!ModelState.IsValid)
            {
                return View("UpdateCategory");
            }
            _categoryManager.Update(category);
            return RedirectToAction("Index");
        }
    }
}
