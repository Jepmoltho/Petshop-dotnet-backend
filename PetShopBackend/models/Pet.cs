using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace PetShopBackend.models
{
    [Table("Pets")]
    public class Pet : Item
    {
        [Column(Order = 1)] 
        public string Name { get; set; }

        [Column(Order = 2)]
        public string Species { get; set; }

        [Column(Order = 3)]
        public string? Breed { get; set; }

        [Column(Order = 4)]
        public int? Age { get; set; }

        [Column(Order = 5)]
        public string? Gender { get; set; }

        [Column(Order = 6)]
        public string? Description { get; set; }

        [Column(Order = 7)]
        public DateTime? Birthdate { get; set; }
    }
}
