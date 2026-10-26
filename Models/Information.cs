using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations;

namespace TPLOCAL1.Models
{
    public class Information
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Forename { get; set; }

        [Display(Name = "Select a gender")]
        [Required]
        public string Gender { get; set; }
        //public List<SelectListItem> Genders { get; set; }
        //public void OnGet()           
        //{
        //    Genders = new List<SelectListItem> {
        //    new SelectListItem { Value = "Select", Text = "Select a gender" },
        //    new SelectListItem { Value = "Man", Text = "Man" },
        //    new SelectListItem { Value = "Woman", Text = "Woman" },
        //    new SelectListItem { Value = "Other", Text = "Other" },
        //    };
        //}

        [Required]
        public string Address { get; set; }

        [RegularExpression(@"^[0-9]{5,5}$")]
        [Required]
        public string ZipCode { get; set; }
        [Required]
        public string Town { get; set; }

        [DataType(DataType.EmailAddress)]
        [Required]
        public string Email { get; set; }

        //[DataType(DateFormat)]
        [Required]
        public string StartDate { get; set; }

        public string TypeTraining { get; set; }

        public string ReviewCobol { get; set; }

        public string ReviewCSharp { get; set; }

    }
}
