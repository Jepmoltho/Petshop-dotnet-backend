using Microsoft.EntityFrameworkCore;
using PetShopBackend.Data;
using PetShopBackend.models;
using System;
using System.Linq;

public static class DbInitializer
{


    public static void Initialize(PetShopContext context)
    {
        context.Database.EnsureCreated(); // Create the database if it doesn't exist

        if (context.Pets.Any())
        {
            return; // The database has been seeded
        }

        //delete all pets in table pet
        // context.Database.ExecuteSqlRaw("DELETE FROM Pets");

        var pets = new Pet[]
        {
            new Pet { Name = "Buddy", Species = "Dog", Birthdate = new DateTime(2018, 5, 15), Price = 1000 },
            new Pet { Name = "Whiskers", Species = "Cat", Birthdate = new DateTime(2019, 3, 10), Price = 199 },
            new Pet { Name = "Daisy", Species = "Dog", Birthdate = new DateTime(2017, 4, 20), Price = 2000 },
            new Pet { Name = "Bella", Species = "Dog", Birthdate = new DateTime(2016, 6, 2) },
            new Pet { Name = "Coco", Species = "Dog", Birthdate = new DateTime(2015, 7, 4) },
            new Pet { Name = "Charlie", Species = "Dog", Birthdate = new DateTime(2014, 8, 6) },
            new Pet { Name = "Lucy", Species = "Cat", Birthdate = new DateTime(2013, 9, 8) },
            new Pet { Name = "Luna", Species = "Cat", Birthdate = new DateTime(2012, 10, 10) },
        };

        context.Pets.AddRange(pets);
        context.SaveChanges();
    }
}
