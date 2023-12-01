

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Wrong Single Responsibility Example Class



namespace Solid.App.SRP.Bad
    
{
    public class Product
    {
        public string Name { get; set; } //get set dışardan okunabilir ve yazılabilir
        public int id { get; set; }

        private static List<Product> ProductList = new List<Product>();

        public List<Product> GetProducts=> ProductList;
      

        public Product() {
            ProductList = new();
            {
                new Product { id = 1, Name = "Kalem1" };
                new Product { id = 2, Name = "Kalem2" };
                new Product { id = 3, Name = "Kalem3" };
                new Product { id = 4, Name = "Kalem4" };
                new Product { id = 5, Name = "Kalem5" };
            };
                
            }
        public void SaveOrUpdate (Product product)
        {
            var hasProduct = ProductList.Any(x => x.id == product.id);
            if (!hasProduct)
            {
                ProductList.Add(product);
             
            }
            else
            {
                var index = ProductList.FindIndex(x => x.id == product.id);
                ProductList[index] = product;
            }
        }
        public void Delete (int id)
        {
            var hasProduct = ProductList.Any(x => x.id == id);
            if (hasProduct != null)
            {
                throw new Exception("Ürün bulunamadı");


            }
            if (hasProduct!=null)
            {
                var index = ProductList.FindIndex(x => x.id == id);
               
            }

        }
        public void WriteToConsole()
        {
            foreach (var product in ProductList)
            {
                Console.WriteLine($"Id: {product.id} Name: {product.Name}");
            }
        }

        }
    }
