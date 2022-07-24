﻿using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetProducts();
        Product GetProductById(int productID);
        void AddProduct(Product product);
        void UpdateProduct(Product product);
        void RemoveProduct(int productID);
        IEnumerable<Product> GetProductByName(string name);
    }
}
