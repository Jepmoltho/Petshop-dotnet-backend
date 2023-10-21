using Microsoft.AspNetCore.Mvc;
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


        // //delete all pets in table pet
        // context.Database.ExecuteSqlRaw("DELETE FROM Pets");
        // context.Database.ExecuteSqlRaw("DELETE FROM Customer");
        // context.Database.ExecuteSqlRaw("DELETE FROM Employee");
        // context.Database.ExecuteSqlRaw("DELETE FROM [Order]");
        // context.Database.ExecuteSqlRaw("DELETE FROM Item");
        // context.Database.ExecuteSqlRaw("DELETE FROM OrderItem");
        // context.Database.ExecuteSqlRaw("DELETE FROM Product");

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

        var customers = new Customer[]
        {
            new Customer { Name = "John", Username = "", Email = ""},
            new Customer { Name = "Jane", Username = "", Email = ""},
            new Customer { Name = "Bob", Username = "", Email = ""},
            new Customer { Name = "Alice", Username = "", Email = ""},
        };

        var employees = new Employee[]
        {
            new Employee { Name = "Allan"},
            new Employee { Name = "Stephe"},
            new Employee { Name = "John"},
        };

        var products = new Product[]
        {
            new Product { ProductName = "Dog Food", ProductType = "Food", Price = 100 },
            new Product { ProductName = "Cat Food", ProductType = "Food", Price = 200 },
            new Product { ProductName = "Dog Toy", ProductType = "Toy", Price = 300 },
            new Product { ProductName = "Cat Toy", ProductType = "Toy", Price = 400 },
            new Product { ProductName = "Dog Bed", ProductType = "Bed", Price = 500 },
            new Product { ProductName = "Cat Bed", ProductType = "Bed", Price = 600 },
            new Product { ProductName = "Dog Collar", ProductType = "Collar", Price = 700 },
            new Product { ProductName = "Cat Collar", ProductType = "Collar", Price = 800 },
            new Product { ProductName = "Dog Leash", ProductType = "Leash", Price = 900 },
            new Product { ProductName = "Cat Leash", ProductType = "Leash", Price = 1000 },
        };

        // var orders = new Order[]
        // {
        //     new Order { CustomerId = 1, EmployeeId = 1, TotalPrice = 1000, OrderDate = new DateTime(2020, 1, 1) },
        //     new Order { CustomerId = 2, EmployeeId = 2, TotalPrice = 2000, OrderDate = new DateTime(2020, 2, 2) },
        //     new Order { CustomerId = 3, EmployeeId = 3, TotalPrice = 3000, OrderDate = new DateTime(2020, 3, 3) },
        //     new Order { CustomerId = 4, EmployeeId = 1, TotalPrice = 4000, OrderDate = new DateTime(2020, 4, 4) },
        //     new Order { CustomerId = 1, EmployeeId = 2, TotalPrice = 5000, OrderDate = new DateTime(2020, 5, 5) },
        //     new Order { CustomerId = 2, EmployeeId = 3, TotalPrice = 6000, OrderDate = new DateTime(2020, 6, 6) },
        //     new Order { CustomerId = 3, EmployeeId = 1, TotalPrice = 7000, OrderDate = new DateTime(2020, 7, 7) },
        //     new Order { CustomerId = 4, EmployeeId = 2, TotalPrice = 8000, OrderDate = new DateTime(2020, 8, 8) },
        //     new Order { CustomerId = 1, EmployeeId = 3, TotalPrice = 9000, OrderDate = new DateTime(2020, 9, 9) },
        //     new Order { CustomerId = 2, EmployeeId = 1, TotalPrice = 10000, OrderDate = new DateTime(2020, 10, 10) },
        // };

        // var items = new Item[]
        // {
        //     new Item { Id = 1, Price = 1000 },
        //     new Item { Id = 2, Price = 2000 },
        //     new Item { Id = 3, Price = 3000 },
        //     new Item { Id = 4, Price = 4000 },
        //     new Item { Id = 5, Price = 5000 },
        //     new Item { Id = 6, Price = 6000 },
        //     new Item { Id = 7, Price = 7000 },
        //     new Item { Id = 8, Price = 8000 },
        //     new Item { Id = 9, Price = 9000 },
        //     new Item { Id = 10, Price = 10000 },
        // };

        // var orderItems = new OrderItem[]
        // {
        //     new OrderItem { OrderId = 1, ItemId = 1, Quantity = 1, SubTotal = 1000 },
        //     new OrderItem { OrderId = 2, ItemId = 2, Quantity = 2, SubTotal = 400 },
        //     new OrderItem { OrderId = 3, ItemId = 3, Quantity = 1, SubTotal = 6000 },
        //     new OrderItem { OrderId = 4, ItemId = 4, Quantity = 2, SubTotal = 8000 },
        //     new OrderItem { OrderId = 5, ItemId = 5, Quantity = 3, SubTotal = 10000 },
        //     new OrderItem { OrderId = 6, ItemId = 6, Quantity = 3, SubTotal = 12000 },
        //     new OrderItem { OrderId = 7, ItemId = 7, Quantity = 1, SubTotal = 14000 },
        //     new OrderItem { OrderId = 8, ItemId = 8, Quantity = 1, SubTotal = 16000 },
        //     new OrderItem { OrderId = 9, ItemId = 9, Quantity = 1, SubTotal = 18000 },
        //     new OrderItem { OrderId = 10, ItemId = 10, Quantity = 1, SubTotal = 20000 },
        // };

        if (!context.Pets.Any())
        {
            context.Pets.AddRange(pets);
        } 

        if (!context.Product.Any())
        {
            context.Product.AddRange(products);
        }
        
        if (!context.Customer.Any())
        {
            context.Customer.AddRange(customers);
        }

        if (!context.Employee.Any())
        {
            context.Employee.AddRange(employees);
        }

        // if (!context.Item.Any())
        // {
        //     context.Item.AddRange(items);
        // }

        // if (!context.Order.Any())
        // {
        //     context.Order.AddRange(orders);
        // }

        // if (!context.OrderItem.Any())
        // {
        //     context.OrderItem.AddRange(orderItems);
        // }




        context.SaveChanges();
    }
}
