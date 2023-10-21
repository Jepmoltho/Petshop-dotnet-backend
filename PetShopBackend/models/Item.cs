using System.ComponentModel.DataAnnotations.Schema;

namespace PetShopBackend.models
{
    public class Item
    {
        [Column(Order = 0)] 
        public int Id { get; set; }

        [Column(Order = 8)]
        public decimal? Price { get; set; }
    }
}