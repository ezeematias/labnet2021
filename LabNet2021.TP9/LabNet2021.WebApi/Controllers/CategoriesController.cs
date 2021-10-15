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
        public IHttpActionResult Get()
        {
            try
            {
                List<Categories> categories = logic.GetAll();
                if (categories != null)
                {
                    List<CategoriesView> categoriesView = categories.Select(c => new CategoriesView
                    {
                        Id = c.CategoryID,
                        CategoryName = c.CategoryName,
                        Description = c.Description
                    }).ToList();
                    return Ok(categoriesView);
                }
                else
                {
                    return BadRequest("Get category failed.");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //GET: Category
        public IHttpActionResult Get(int id)
        {
            try
            {
                Categories categories = logic.Get(id);
                if (categories != null)
                {
                    CategoriesView categoriesView = new CategoriesView
                    {
                        Id = categories.CategoryID,
                        CategoryName = categories.CategoryName,
                        Description = categories.Description
                    };
                    return Ok(categoriesView);
                }
                else
                {
                    return BadRequest("Get category failed.");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //POST: Add Category
        public IHttpActionResult Post(CategoriesView categoriesView)
        {
            try
            {
                if (categoriesView != null)
                {
                    var categoryEntity = new Categories { CategoryName = categoriesView.CategoryName, Description = categoriesView.Description };
                    logic.Add(categoryEntity);
                    return Ok("Successfully added");
                }
                else
                {
                    return BadRequest("Add failed");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //PUT: Update Categories
        public IHttpActionResult Put(CategoriesView categoriesView)
        {
            try
            {
                if (categoriesView != null && logic.Find(categoriesView.Id))
                {
                    var categoryEntity = new Categories { CategoryID = categoriesView.Id, CategoryName = categoriesView.CategoryName, Description = categoriesView.Description };
                    logic.Update(categoryEntity);
                    return Ok("Successfully modified");
                }
                else
                {
                    return BadRequest("Modification failed");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //DELETE: Delete Categories
        public IHttpActionResult Delete(int id)
        {
            try
            {
                if (logic.Find(id))
                {
                    logic.Delete(id);
                    return Ok("Successfully removed");
                }
                else
                {
                    return BadRequest("The id is not valid.");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
