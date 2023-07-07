﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProductMicroService.Models;

namespace ProductMicroService.Repository
{
    public interface IProductRepository
    {   
        IEnumerable<Product> GetProducts();
        Product GetProductByID(int ProductId);
        void InsertProduct(Product Product);
        void DeleteProduct(int ProductId);

        void UpdateProduct(Product Product);

        void Save();
    }
}
