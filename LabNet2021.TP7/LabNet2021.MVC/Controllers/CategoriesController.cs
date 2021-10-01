using LabNet2021.Entities;
using LabNet2021.Logic;
using LabNet2021.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LabNet2021.MVC.Controllers
{
    public class CategoriesController : Controller
    {
        CategoriesLogic logic = new CategoriesLogic();
        // GET: Categories
        public ActionResult Index()
        {
            try
            {
                List<Categories> categories = logic.GetAll();
                List<CategoriesView> categoriesView = categories.Select(c => new CategoriesView
                {
                    Id = c.CategoryID,
                    CategoryName = c.CategoryName,
                    Description = c.Description
                }).ToList();
                return View(categoriesView);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public ActionResult Insert()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Insert(CategoriesView categoriesView)
        {
            try
            {
                var categoryEntity = new Categories { CategoryName = categoriesView.CategoryName, Description = categoriesView.Description };
                logic.Add(categoryEntity);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return RedirectToAction("Index", "Error", new { ex.Message });
            }
        }

        public ActionResult Delete(int id)
        {
            try
            {
                logic.Delete(id);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return RedirectToAction("Index", "Error", new { ex.Message });
            }
        }

        [HttpPost]
        public ActionResult Update(CategoriesView categoriesView)
        {
            try
            {
                var categoryEntity = new Categories { CategoryID = categoriesView.Id, CategoryName = categoriesView.CategoryName, Description = categoriesView.Description };
                logic.Update(categoryEntity);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return RedirectToAction("Index", "Error", new { ex.Message });
            }
        }

        public ActionResult Update(string id, string categoryName, string description)
        { 
            ViewBag.Id = id;
            ViewBag.CategoryName = categoryName;
            ViewBag.Description = description;
            return View("Insert");
        }
    }
}