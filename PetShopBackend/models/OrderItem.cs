using System.ComponentModel.DataAnnotations.Schema;

namespace PetShopBackend.models
{
    public class OrderItem
    {
        public int Id { get; set; }

        [ForeignKey("Order")]
        public int OrderId { get; set; }

        [ForeignKey("Item")]
        public int ItemId { get; set; }

        // public ItemType ItemType { get; set; }
        public int Quantity { get; set; }
        public decimal SubTotal { get; set; }
    }

    // public enum ItemType
    // {
    //     Pet, 
    //     Product
    // }
}