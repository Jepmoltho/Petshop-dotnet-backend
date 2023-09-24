using System;

namespace PetShopBackend.Models
{
    public class Pet
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Species { get; set; }
        public DateTime Birthdate { get; set; }
        // Add other properties as needed
    }
}
