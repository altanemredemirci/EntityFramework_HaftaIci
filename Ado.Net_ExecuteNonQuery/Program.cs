namespace Ado.Net_ExecuteNonQuery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Execute execute = new Execute();

            #region Insert1
            //if (Execute.Insert() > 0)
            //{
            //    Console.WriteLine("Kayıt Eklendi.");
            //}
            //else
            //{
            //    Console.WriteLine("Hata Oluştu.");
            //}
            #endregion

            #region InsertParams

            Product p = new Product();
            Console.WriteLine("Ürün Adı:");
            p.Name = Console.ReadLine();
            Console.WriteLine("Ürün Fiyat:");
            p.Price = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ürün Stok:");
            p.Stock= Convert.ToInt32(Console.ReadLine());


            if (execute.InsertParams(p) > 0)
            {
                Console.WriteLine("Kayıt Eklendi");
            }
            else 
            {
                Console.WriteLine("Hata Oluştu");
            }

            #endregion

        }
    }
}
