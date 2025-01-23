using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
        public class Produit
        {

            public int Id { get; set; }

            [Display(Name = "Designation")]
            [Required(ErrorMessage = "Merci de saisir le nom")]
            [MinLength(2, ErrorMessage = "Au moins deux caractères")]
            public string Name { get; set; }
            [Display(Name = "Prix")]
            [Required(ErrorMessage = "Merci de saisir le prix")]
            public double Price { get; set; }
        }
    }
