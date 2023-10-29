using System.ComponentModel.DataAnnotations.Schema;

namespace PetShopBackend.models
{
    public class Order
    {
        public int Id { get; set; }

        [ForeignKey("Customer")]
        public int CustomerId { get; set; }

        [ForeignKey("Employee")]
        public int EmployeeId { get; set; }
        public decimal TotalPrice { get; set; }
        public DateTime OrderDate { get; set; }
        public List<OrderItem> OrderItems { get; set; }

    }
}