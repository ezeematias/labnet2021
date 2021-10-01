using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LabNet2021.MVC.Models
{
    public class ShippersView
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Company Name")]
        [Required(ErrorMessage = "Required")]
        [StringLength(40, ErrorMessage = "Length between 3 and 40 characters", MinimumLength = 3)]
        public string CompanyName { get; set; }

        [Display(Name = "Phone")]
        [StringLength(24)]
        [RegularExpression(@"^[(]*[0-9]*[0-9]*[)]*[' ']*[0-9]*[0-9]*[-]*[0-9]*$", ErrorMessage = "it is not a valid phone number")]
        public string Phone { get; set; }
    }
}