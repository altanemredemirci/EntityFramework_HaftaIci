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

        internal void ProductList()
        {
            double productCount = db.Products.Count(); //77
            int pageSize = 10;

            decimal pageCount = Math.Ceiling(Convert.ToDecimal(productCount / pageSize));

            for (int i = 0; i < pageCount; i++)
            {
                var list = db.Products.Skip(i * pageSize).Take(pageSize);
            }

        }

        internal bool Search(Customer key)
        {
            var customers = db.Customers.Contains(key);
                 
            return customers;
        }

        internal Customer FindSearch(string key)
        {
            //var customer = db.Customers.Find(key);
            //var customer = db.Customers.Include(i=> i.Orders).FirstOrDefault(i=> i.CustomerId==key);
            var orders = db.Customers
                            .Include(i => i.Orders)
                            .Where(i => i.CustomerId == key)
                            //.Select(i => i.Orders)
                            .ToList();

            //ALFKI 
            var siparisler = db.Orders.Where(i => i.CustomerId == key).ToList();

            return null;
        }

        internal IQueryable<Category> CustomerByCategoryId(int catId)
        {

            //var category = db.Categories
            //    .Where(c => c.CategoryId == catId)
            //    .Include(c=> c.Products)
            //    .ThenInclude(p=> p.OrderDetails)
            //    .ThenInclude(od=>od.Order)
            //    .ThenInclude(o=> o.Customer)
            //    .FirstOrDefault();

            db.Categories.Where(c => c.CategoryId == catId).Select(c => c.CategoryName);
            var category =  from c in db.Categories where c.CategoryId == catId select c ;

            return category;
        }


    }

    class ProductSumQuantity
    {
        public int ProductId { get; set; }
        public int SumQuantity { get; set; }
    }

    /*
    List - IEnumrable : Kod çalışır Ürünler komple gelir ve ramde tutulur.

    IQueryable : Kod çalışır ama ürünler veritabanında getirilmez de herhangi bir işlem yapılacak ise tekrar veritabanına gidilir.
     
     
     
     */




}
