using EF_2_CodeFirst.Context;
using EF_2_CodeFirst.Entity;

namespace EF_2_CodeFirst
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataContext db = new DataContext();

            var products = db.Products.Where(i => i.CategoryId == 1).ToList();

        }
    }
}

/*
 ********* CODEFIRST *********
 *CodeFirst bir projenin şablonun C# tarafında(yazılım) oluşturulması ve veritabani,tablolar,ilişkiler,kısıtlamalar vb özelliklerin yazılım tarafında sürdürülmesine denir.
 
   ### Adım Adım CodeFirst ###
1-Entity Framework Core paketi kurulur.
2-Projede kullanılacak enitity - objects ve aralarındaki ilişkiler, her entity nin property lerinin attribute leri tanımlanır. (Entity klasör veya Entity proje katmanı)
3-DbContext classından miras alan, bize veritabani bağlantısı ve işlemlerini yapmamaızı sağlayan bir class tanımlanır.
4-DbContext classı sayesinde veritabanı bağlantısı yazılır ve tablo olmasını istediğimiz entity ler DbSet<> komutu ile set edilir.
    4.1 - DatabaseConnectionString yazmanın 3 farklı yöntemi vardır.
        4.1.1 - DbContext.cs miras alan class içerisinde OnConfiguring() metodunu override ederek UseSqlServer() metoduna parametre olarak bağlantı kodunu göndermek. 
        4.1.2 - Program.cs altında bir servis tanımlayarak yine UseSqlServer() metdouna parametre olarak bağlantı cümlesini göndermek
        4.1.3 - Appsetting.json dosyası altında ConnectionString etiketinde key,value olarak tanımlamak.
        ** UseSqlServer() metodu Microsoft.EntityFrameworkCore.SqlServer paket kurulumuyla gelir.
5-Add-Migration ["MigrationName"]
6-Update-Database
 

  ### RELATIONS - ORM - Object Relation Mapping ###
1-1 OneToOne   TC-Vatandas    Şehir-Plaka
1-N OneToMany  Category-Product  Öğrenci(Id,Ad,Numara)-Sınıf(Id-Ad) 
N-N ManyToMany Brand-Category  


 */