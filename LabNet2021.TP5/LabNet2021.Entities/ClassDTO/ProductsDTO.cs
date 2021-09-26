using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNet2021.Entities.ClassDTO
{
    public class ProductsDTO
    {
        [Key]
        public int ProductID { get; set; }

        [Required]
        [StringLength(40)]
        public string ProductName { get; set; }
        public short? UnitsInStock { get; set; }        
        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }

        [StringLength(20)]
        public string QuantityPerUnit { get; set; }        
        public decimal? UnitPrice { get; set; }     

    }
}
