using System;
using System.Collections.Generic;
using System.Text;
using GameDemo.Entities;

namespace GameDemo.Abstract
{
    public class ProductManager:IProductManager
    {
        public void Add(Product product)
        {
            Console.WriteLine("{0} ürün başarıyla eklendi.", product.ProductName);
        }

        public void Update(Product product)
        {
            Console.WriteLine("{0} ürün başarıyla güncellendi.", product.ProductName);
        }

        public void Delete(Product product)
        {
            Console.WriteLine("{0} ürün başarıyla silindi.", product.ProductName);
        }

        public void GetAll(List<Product> products)
        {
            foreach (var product in products)
            {
                Console.WriteLine("Ürün Id : {0} - Ürün Adı : {1} - Ürün Fiyatı : {2}\n",product.ProductId,product.ProductName,product.ProductUnitPrice);

            }

            Console.ReadLine();


        }
    }
}
