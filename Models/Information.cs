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
        public DateFormat StartDate { get; set; }

        public string TypeTraining { get; set; }

        public string ReviewCobol { get; set; }

        public string ReviewCSharp { get; set; }

    }
}
