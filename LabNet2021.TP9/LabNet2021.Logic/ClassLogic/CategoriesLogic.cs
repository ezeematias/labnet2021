using LabNet2021.Data;
using LabNet2021.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNet2021.Logic
{
    public class CategoriesLogic : BaseLogic, IABMLogic<Categories>
    {
        /// <summary>
        /// Get a list of Categories
        /// </summary>
        /// <returns>List of Categories</returns>
        public List<Categories> GetAll()
        {
            try
            {
                return context.Categories.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Add a Categories
        /// </summary>
        /// <param name="addCategories">Categories to add</param>
        public void Add(Categories addCategories)
        {
            try
            {
                context.Categories.Add(addCategories);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Delete a Categories
        /// </summary>
        /// <param name="id">Categories ID</param>
        public void Delete(int id)
        {
            try
            {
                var categoriesDelete = context.Categories.Find(id);
                if (categoriesDelete != null)
                {
                    context.Categories.Remove(categoriesDelete);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("The category to delete was not found.");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Modify a Categories
        /// </summary>
        /// <param name="updateCategories">Categories to modify.</param>
        public void Update(Categories updateCategories)
        {
            try
            {
                var bufferCategories = context.Categories.Find(updateCategories.CategoryID);
                if (bufferCategories != null)
                {
                    bufferCategories.CategoryName = updateCategories.CategoryName;
                    bufferCategories.Description = updateCategories.Description;
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("The category to modify was not found.");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Find a Categories
        /// </summary>
        /// <param name="id">Categories ID</param>
        /// <returns>If the Categories exists, return TRUE, otherwise FALSE</returns>
        public bool Find(int id)
        {
            try
            {
                bool output = false;
                var bufferCategories = context.Categories.Find(id);
                if (bufferCategories != null)
                {
                    output = true;
                }
                return output;
            }
            catch (Exception ex)
            {
                throw ex;
            }            
        }

        /// <summary>
        /// Find a Categories
        /// </summary>
        /// <param name="id">Categories ID</param>
        /// <returns>If the Categories exists, return Category, otherwise NULL</returns>
        public Categories Get(int id)
        {
            try
            {                
                var bufferCategories = context.Categories.Find(id);
                if(bufferCategories == null)
                {
                    throw new Exception("The id is not valid.");
                }
                return bufferCategories;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
