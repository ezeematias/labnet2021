using LabNet2021.Entities;
using LabNet2021.Entities.ClassDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNet2021.Logic
{
    public class ProductsLogic : BaseLogic, ILogic<Products>
    {
        public List<Products> GetAll()
        {
            return context.Products.ToList();
        }

        public List<ProductsDTO> AllProductsOutOfStock()
        {
            var query = context.Products.Where(p => p.UnitsInStock == 0).Select(p => new ProductsDTO() { ProductID = p.ProductID, ProductName = p.ProductName, UnitPrice = p.UnitPrice, UnitsInStock = p.UnitsInStock }).ToList();
            return query;
        }

        public List<ProductsDTO> AllProductsInStockAndCostMoreThree()
        {
            var query = context.Products.Where(p => p.UnitsInStock > 0).Where(p => p.UnitPrice > 3).Select(p => new ProductsDTO() { ProductID = p.ProductID, ProductName = p.ProductName, UnitPrice = p.UnitPrice, UnitsInStock = p.UnitsInStock }).ToList();
            return query;
        }

        public Products ProductsForID(int id)
        {
            var query = context.Products.FirstOrDefault(p => p.ProductID == id);
            return query;
        }


    }
}
