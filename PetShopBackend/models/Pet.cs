using System;

namespace PetShopBackend.models
{
    public class Pet : Item
    {
        public string Name { get; set; }
        public string Species { get; set; }
        public string? Breed { get; set; }
        public int? Age { get; set; }
        public string? Gender { get; set; }
        public string? Description { get; set; }
        public DateTime? Birthdate { get; set; }
    }
}
