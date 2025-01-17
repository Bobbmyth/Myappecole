// using System.ComponentModel.DataAnnotations;

// namespace WebApplication1.Models
// {
//     public class Produit
//     {

//         public int Id { get; set; }

//         [Required]
//         [StringLength(100, MinimumLength =3 )] 
//         public string Name { get; set; }

//         [Required]
//         [Range(0.01, 1000000)]
//         public decimal Price { get; set; }
//     }
// }


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
