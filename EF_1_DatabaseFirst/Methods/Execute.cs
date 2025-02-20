using EF_1_DatabaseFirst.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_1_DatabaseFirst.Methods
{
    internal class Execute
    {
        NorthwindContext db = new NorthwindContext();

        internal Order OrderGetById(int id)
        {
            //Order order = db.Orders.Include(i=> i.Customer).Where(i => i.OrderId == id).FirstOrDefault() ?? new Order();
            Order order = db.Orders.Include(i => i.Customer).FirstOrDefault(i => i.OrderId == id) ?? new Order();

            return order;
        }

        internal List<Order> GetOrders()
        {
            return db.Orders.OrderByDescending(i => i.OrderDate).ToList();
        }

        //select ProductID,SUM(Quantity) from [Order Details] group by ProductID
        internal List<ProductSumQuantity> ProductGetQuantity()
        {
            var models = db.OrderDetails
                           .GroupBy(i => i.ProductId) // Group by ProductId
                           .Select(g => new ProductSumQuantity
                           {
                               ProductId = g.Key, // ProductId from the group
                               SumQuantity = g.Sum(i => i.Quantity) // Sum of Quantity in the group
                           })
                           .ToList();

            return models;
        }

        internal List<Product> ProductsGetByCategory(int categoryId = 0)
        {
            #region 1.Yöntem
            //if (categoryId > 0)
            //{
            //    return db.Products.Where(i => i.CategoryId == categoryId).ToList();
            //}

            //else
            //{
            //    return db.Products.ToList();
            //}

            #endregion

            #region 2.Yöntem
            //if (categoryId > 0)
            //{
            //    return db.Products.Where(i => i.CategoryId == categoryId).ToList();
            //}

            //return db.Products.ToList();
            #endregion

            var products = db.Products.AsQueryable(); //SQL sorgusunu tamamlanmadı olarak işaretledi. Cümlenin sonuna virgül koydu.

            if (categoryId > 0)
            {
                products = products.Where(i => i.CategoryId == categoryId);
            }

            return products.ToList();
            
        }

    }

    class ProductSumQuantity
    {
        public int ProductId { get; set; }
        public int SumQuantity { get; set; }
    }
}
