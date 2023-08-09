using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityFALSE.App
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }

        private static List<Product> ProductsList = new List<Product>();

        //public List<Product> GetProducts{ get{return  ProductsList;}}
        public List<Product> GetProducts => ProductsList;
        public Product()
        {
 
 
        }

        public void SaveOrUpdate(Product product)
        {
            var hasProduct = ProductsList.Any(p => p.Id == product.Id);
            if (!hasProduct)
                ProductsList.Add(product);
            else
            {
                var index = ProductsList.IndexOf(product);
                ProductsList[index] = product;
            }
        }

        public void Delete(int id)
        {
            var hasProduct = ProductsList.Find(p => p.Id == id);
            if (hasProduct == null)
                throw new Exception($"{id} Nolu Ürün Bulunmadı.");

            ProductsList.Remove(hasProduct);
        }

        public void WriteToConsole()
        {
            GetProducts.ForEach(p =>
            {
                Console.WriteLine($"Id : {p.Id} Name : {p.Name}");
            }); 
        }
    }
}
