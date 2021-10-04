using LabNet2021.Entities;
using LabNet2021.Logic;
using LabNet2021.WebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace LabNet2021.WebApi.Controllers
{
    public class CategoriesController : ApiController
    {
        CategoriesLogic logic = new CategoriesLogic();

        //GET: All Categories
        public List<CategoriesView> Get()
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
                return categoriesView;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //GET: Category
        public CategoriesView Get(int id)
        {
            try
            {
                Categories categories = logic.Get(id);
                CategoriesView categoriesView = new CategoriesView
                {
                    Id = categories.CategoryID,
                    CategoryName = categories.CategoryName,
                    Description = categories.Description
                };
                return categoriesView;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //POST: Add Category
        public void Post(string categoryName, string description)
        {
            try
            {
                var categoryEntity = new Categories { CategoryName = categoryName, Description = description };
                logic.Add(categoryEntity);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //PUT: Update Categories
        public void Put(int id, string categoryName, string description)
        {
            try
            {
                if (logic.Find(id))
                {
                    var categoryEntity = new Categories { CategoryID = id, CategoryName = categoryName, Description = description };
                    logic.Update(categoryEntity);
                }
                else
                {
                    throw new Exception("The id is not valid.");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //DELETE: Delete Categories
        public void Delete(int id)
        {
            try
            {
                logic.Delete(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
