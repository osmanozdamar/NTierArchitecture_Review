using DataAccessLayer.Context;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLayer
{
    public class ProductOperations
    {
        //tümünü getir
        public List<Product> GetAll()
        {
            NorthWndContext cnt = new NorthWndContext();
            List<Product> products = cnt.Products.ToList();
            return products;
        }
        //id ye göre getir
        public Product GetById(int pId)
        {
            NorthWndContext cnt = new NorthWndContext();
            var product = cnt.Products.SingleOrDefault(x=> x.ProductId==pId);
            return product;
        }

        //fiyata göre getir
        public Product GetByPrice(int price)
        {
            NorthWndContext cnt = new NorthWndContext();
            var products =cnt.Products.SingleOrDefault(x=> x.UnitPrice==price);
            return products;
        }
    }
}