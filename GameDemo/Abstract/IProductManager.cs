using System;
using System.Collections.Generic;
using System.Text;
using GameDemo.Entities;

namespace GameDemo.Abstract
{
    public interface IProductManager
    {
        void Add(Product product);
        void Update(Product product);
        void Delete(Product product);
        void GetAll(List<Product> products);

    }
}
