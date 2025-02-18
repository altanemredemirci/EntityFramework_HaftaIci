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
 */

using EF_1_DatabaseFirst.Entities;
using Microsoft.EntityFrameworkCore;

NorthwindContext db = new NorthwindContext();

//foreach (var item in db.Products.Include(i=>i.Category).ToList())
//foreach (var item in db.Products.Include("Category").ToList())
//{
//    Console.WriteLine(item.ProductId + " " + item.ProductName+" "+item.Category.CategoryName);
//}

var products = db.Products.Where(i => i.CategoryId > 3).ToList();

foreach (var item in products)
{
    Console.WriteLine(item.ProductName+" "+item.CategoryId);
}




