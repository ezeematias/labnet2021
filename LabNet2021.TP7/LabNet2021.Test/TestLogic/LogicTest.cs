using LabNet2021.Entities;
using LabNet2021.Logic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace LabNet2021.Test
{
    [TestClass]
    public class LogicTest
    {
        /// <summary>
        /// Add a Shippers to the database and check that it is saved correctly.
        /// </summary>
        [TestMethod]
        public void ShippersLogic_AddShippers_SuccessufullyAdded()
        {
            //Arrange
            ShippersLogic shippersLogic = new ShippersLogic();
            Shippers shippers = new Shippers { CompanyName = "Testing ADD" , Phone = "(011) 4203-4819" };
            int count = shippersLogic.GetAll().Count;

            //Act
            shippersLogic.Add(shippers);

            //Assert
            Assert.IsTrue(count < shippersLogic.GetAll().Count);
            Assert.IsTrue(shippersLogic.Find(shippers.ShipperID));
        }

        /// <summary>
        /// We obtain the entire list of Shippers found at the base and we check that they are brought in correctly.
        /// </summary>
        [TestMethod]
        public void ShippersLogic_GetShippers_ListGetAll()
        {
            //Arrange
            ShippersLogic shippersLogic = new ShippersLogic();
            Shippers shippers = new Shippers { CompanyName = "Testing GET", Phone = "(011) 4203-4819" };
            List<Shippers> shippersGet = new List<Shippers>();
            shippersLogic.Add(shippers);

            //Act
            shippersGet = shippersLogic.GetAll();

            //Assert
            Assert.IsNotNull(shippers);
            Assert.IsTrue(shippersGet.Count > 0);
        }

        /// <summary>
        /// We delete a category and we check that this category is correctly removed from the database.
        /// </summary>
        [TestMethod]
        public void CategoriesLogic_DeleteCategories_SuccessufullyDeleted()
        {
            //Assert
            CategoriesLogic categoriesLogic = new CategoriesLogic();
            Categories categories = new Categories { CategoryName = "Testing DELETE", Description = "Deleted successfully" };
            categoriesLogic.Add(categories);

            //Act
            categoriesLogic.Delete(categories.CategoryID);

            //Assert
            Assert.IsFalse(categoriesLogic.Find(categories.CategoryID));
        }

        /// <summary>
        /// We modify a category and check that this category is changed correctly in the database.
        /// </summary>
        [TestMethod]
        public void CategoriesLogic_UpdateCategories_SuccessufullyModified()
        {
            //Assert
            CategoriesLogic categoriesLogic = new CategoriesLogic();
            Categories categories = new Categories { CategoryName = "Testing UP", Description = "Deleted successfully" };
            categoriesLogic.Add(categories);
            categories.CategoryName = "Testing UPDATE";
            categories.Description = "Update successfully";

            //Act
            categoriesLogic.Update(categories);

            //Assert
            Assert.IsFalse(categories.CategoryName == "Testing UP");
        }
    }
}
