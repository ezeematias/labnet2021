using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNet2021.Entities.ClassDTO
{
    public class OrdersDTO
    {
        [Key]
        public int OrderID { get; set; }

        [StringLength(40)]
        public string CompanyName { get; set; }

        [StringLength(15)]
        public string Region { get; set; }

        public DateTime? OrderDate { get; set; }
    }
}
