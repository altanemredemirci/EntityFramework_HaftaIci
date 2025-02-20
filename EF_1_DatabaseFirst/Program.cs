/*
 
******* ORM - Object Relation Mapping *******
* Entity Framework (682ms)
* Ado.Net (43ms)
* Dapper  (48ms)

********* ENTITY FRAMEWORK ***********
EF Çeşitleri
    1-CodeFirst
    2-Database First
    3-Model First
    4-Code First(varolan database)
 
 ******** DATABASE FIRST ********
 Scaffold-DbContext "Server=DESKTOP-58CMK8T\SQLDERS;Database=Northwind;Trusted_Connection=True; TrustServerCertificate=true;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Entities


NorthwindContext db = new NorthwindContext();

        //foreach (var item in db.Products.Include(i=>i.Category).ToList())
        foreach (var item in db.Products.Include("Category").ToList())
        {
            Console.WriteLine(item.ProductId + " " + item.ProductName + " " + item.Category.CategoryName);
        }



 */



using EF_1_DatabaseFirst.Entities;
using EF_1_DatabaseFirst.Methods;
using Microsoft.EntityFrameworkCore;

class Program
{
    static void Main()
    {
        Execute execute = new Execute();

        #region Kendisine parametre olarak verilen OrderId datası ile sipariş bilgisini döndüren method

        //Order order = execute.OrderGetById(10249);

        //Console.WriteLine(order.OrderId+" "+order.CustomerId+" "+order.Customer.CompanyName+" "+order.Customer.ContactName+ " "+order.OrderDate);
        #endregion


        #region Siparişleri sipariş tarihine göre en yeniden en eski siparişe doğru sıralayarak ekrana yazdırınız.

        //var orders = execute.GetOrders();

        //if (orders.Count > 0)
        //{
        //    foreach (var item in orders)
        //    {
        //        Console.WriteLine(item.OrderId+" "+item.OrderDate);
        //    }
        //}


        #endregion


        #region Her üründen toplam verilen sipariş ürün adetini ProductId ve Toplam Ürün sayısı olarak listeleyiniz.

        //foreach (var item in execute.ProductGetQuantity())
        //{
        //    Console.WriteLine(item.ProductId+":"+item.SumQuantity);
        //}
        //Console.WriteLine("------------------");

        //execute.ProductGetQuantity().ForEach(i => Console.WriteLine(i.ProductId + ":" + i.SumQuantity)); //ForeachOneLine
        #endregion


        #region Kendisine categoryId parametresi gelirse o kategorideki ürünleri, gelmezse bütün ürünleri listeleyen LINQ komutunu yazınız.

        execute.ProductsGetByCategory().ForEach(i => Console.WriteLine(i.ProductId + " " + i.ProductName));

        Console.WriteLine("------------------------");

        execute.ProductsGetByCategory(1).ForEach(i => Console.WriteLine(i.ProductId + " " + i.ProductName));


        #endregion


        /*
            db.Products.Any();
            db.Products.Take();
            db.Products.Skip();
            db.Products.AsTracking();
            db.Products.Contains();
            db.Products.DistinctBy();
            db.Products.FirstOrDefault() SingleOrDefault()     farkları
            db.Products.FromSql();
            db.Products.Join();
         */
    }


}




