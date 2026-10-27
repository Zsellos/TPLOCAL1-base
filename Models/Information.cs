using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations;

namespace TPLOCAL1.Models
{
    public class Information
    {
        [Required(ErrorMessage = "Le nom est obligatoire")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Le prénom est obligatoire")]
        public string Forename { get; set; }

        //[Display(Name = "Select a gender")]
        [Required(ErrorMessage = "Vous devez choisir un sexe")]
        public string Gender { get; set; }

        [Required(ErrorMessage = "L'adresse est obligatoire")]
        public string Address { get; set; }

        [RegularExpression(@"^[0-9]{5,5}$", ErrorMessage = "Le code postal doit être composé de 5 chiffres")]
        [Required(ErrorMessage = "Le Code postal est obligatoire")]
        public string ZipCode { get; set; }

        [Required(ErrorMessage = "La ville est obligatoire")]
        public string Town { get; set; }

        [DataType(DataType.EmailAddress, ErrorMessage = "Format invalide pour l'adresse email")]
        [Required(ErrorMessage = "Une addresse email est nécessaire")]
        public string Email { get; set; }

        [Range(typeof(DateTime), "01/01/0001 00:00", "31/12/2020 00:00", ErrorMessage = "La date doit être inférieure à 01/01/2021")]
        [Required]
        public DateTime StartDate { get; set; } = new DateTime(2021,1,1);

        [Required(ErrorMessage = "Vous devez selectionner une formation")]
        public string TypeTraining { get; set; }

        [Required(ErrorMessage = "Vous devez rentrer un avis")]
        public string? ReviewCobol { get; set; }

        [Required(ErrorMessage = "Vous devez rentrer un avis")]
        public string? ReviewCSharp { get; set; }

    }
}
