using System.ComponentModel.DataAnnotations.Schema;

namespace PetShopBackend.models
{
    public class Product : Item
    {
        [Column(Order = 1)]
        public string ProductName { get; set; }

        [Column(Order = 2)]
        public string ProductType { get; set; }
    }
}