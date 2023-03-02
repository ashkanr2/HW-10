using System;
using System.Globalization;
using System.Xml.Linq;
using _10.Models;
using static System.Reflection.Metadata.BlobBuilder;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace _10.Data_Access
{
    public class ProductRippo
    {
            public static List<Product> Products = new List<Product>
            {new Product
        {Id = 1,Name = "Galaxy s22",Number=3,Number2=1,Price=1000,PersonId=2},
        new Product
        {Id = 2,Name = "Iphone 14",Number=5,Price=1000},
        new Product
        {Id = 3,Name = "Laptop Lenovo",Number=1,Number2=1,Price=1200,PersonId=2},
        new Product
        {Id = 4,Name = "Nokia 1100",Number=35,Price=100},
        new Product
        {Id = 5,Name = "Chips ",Number=4,Price=2},
        new Product
        {Id = 6,Name = "Chocolate",Number=3,Number2=3,Price=1},
        new Product
        {Id = 7,Name = "Lamp",Number=5,Number2 = 5, Price=5},
        new Product
        {Id = 8,Name = "Toy",Number=12,Number2 = 12, Price=10},
         new Product
        {Id = 9,Name = "Knife",Number=3,Number2 = 3, Price=10},
          new Product
        {Id =10,Name = "Shotgun",Number=12,Number2 = 12, Price=400},

        };
        public List<Product> GetList()
        {
            return Products;
        }
        public void Add(Product product)
        {
            Products.Add(product);
        }
        public void Delete(int id)
        {
            var entity = Products.FirstOrDefault(x => x.Id == id);
            Products.Remove(entity);
        }
        public Product Get(int id)
        {
            var entity = Products.FirstOrDefault(x => x.Id == id);
            return entity;
        }
        public void Edite(int id, string name, int number,decimal price)
        {
            var entity = Get(id);
            entity.Name = name;
            entity.Number = number;
            entity.Price = price;
        }
    }
}
