using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Client

    {

        public int Id { get; set; }


        [Required(ErrorMessage = "Merci de saisir un nom")]
        [MinLength(1, ErrorMessage = "Au moins un caractère")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Merci de saisir un prénom")]
        [MinLength(1, ErrorMessage = "Au moins un caractère")]
        public string Prenom { get; set; }

        [Required(ErrorMessage = "Merci de saisir une adresse email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Merci de saisir un mot de passe")]
        [MinLength(8, ErrorMessage = "Au moins huit caractères")]
        public string Password { get; set; }

    }
}