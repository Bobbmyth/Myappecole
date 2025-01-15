using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Catalogue
    {

        [Key]
        public int numero { get; set; }
        public string NomCategorie { get; set; }
        public decimal Prix { get; set; }
    }
}
