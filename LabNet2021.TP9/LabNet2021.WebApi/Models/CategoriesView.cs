using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LabNet2021.WebApi.Models
{
    public class CategoriesView
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Category Name")]
        [Required(ErrorMessage = "Required")]
        [StringLength(15, ErrorMessage = "Length between 3 and 15 characters", MinimumLength = 3)]
        public string CategoryName { get; set; }

        [Display(Name = "Description")]
        [Column(TypeName = "ntext")]
        [StringLength(100, ErrorMessage = "Maximum length is 100 characters")]
        public string Description { get; set; }
    }
}