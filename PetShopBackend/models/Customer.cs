using System.ComponentModel.DataAnnotations.Schema;

namespace PetShopBackend.models
{
    public class Customer
    {
        [Column(Order = 0)]
        public int Id { get; set; }

        [Column(Order = 1)]
        public string? Name { get; set; }
        public string? Email {get; set;}
        public string? Username { get; set; }
        public string? Password { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}