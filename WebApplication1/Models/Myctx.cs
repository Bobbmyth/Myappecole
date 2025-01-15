using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Models
{
    public class Myctx : DbContext 
    {

        public Myctx(DbContextOptions<Myctx> options) : base(options)
        {
        }

        public DbSet<Client> Clients { get; set; }

        public DbSet <Produit> Produits { get; set;}

        public DbSet <Catalogue> Catalogues { get; set; }



    }

}
