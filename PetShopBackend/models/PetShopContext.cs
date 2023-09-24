using Microsoft.EntityFrameworkCore;
using PetShopBackend.Models;

namespace PetShopBackend.Data
{
    public class PetShopContext : DbContext
    {
        public PetShopContext(DbContextOptions<PetShopContext> options) : base(options) { }

        public DbSet<Pet> Pets { get; set; }
    }
}
