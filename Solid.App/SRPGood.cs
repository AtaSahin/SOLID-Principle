

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;



//Right Single Responsibility Example Class

namespace Solid.App.SRP.Good
    
{
    // Product.cs
    public class Product
    {
        public string Name { get; set; }
        public int Id { get; set; }
    }

    // ProductRepository.cs
    public class ProductRepository
    {
        public List<Product> GetProducts()
        {
            return new List<Product>
        {
            new Product { Id = 1, Name = "Kalem1" },
            new Product { Id = 2, Name = "Kalem2" },
            new Product { Id = 3, Name = "Kalem3" },
            new Product { Id = 4, Name = "Kalem4" },
            new Product { Id = 5, Name = "Kalem5" }
        };
        }
    }

    // ProductPresenter.cs
    public class ProductPresenter
    {
        public void WriteToConsole(List<Product> productList)
        {
            foreach (var product in productList)
            {
                Console.WriteLine($"Id: {product.Id} Name: {product.Name}");
            }
        }
    }

    // ProductService.cs
    public class ProductService
    {
        private static List<Product> ProductList = new List<Product>();

        public List<Product> GetProducts() => ProductList;

        public void SaveOrUpdate(Product product)
        {
            var hasProduct = ProductList.Any(x => x.Id == product.Id);
            if (!hasProduct)
            {
                ProductList.Add(product);
            }
            else
            {
                var index = ProductList.FindIndex(x => x.Id == product.Id);
                ProductList[index] = product;
            }
        }

        public void Delete(int id)
        {
            var hasProduct = ProductList.Any(x => x.Id == id);
            if (!hasProduct)
            {
                throw new Exception("Ürün bulunamadı");
            }

            var index = ProductList.FindIndex(x => x.Id == id);
            ProductList.RemoveAt(index);
        }
    }

}
