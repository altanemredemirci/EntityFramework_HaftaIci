using Microsoft.Data.SqlClient;

namespace Ado.Net_ExecuteReader
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Execute execute = new Execute();

            SqlDataReader reader = execute.Select();

            while (reader.Read())
            {
                Console.WriteLine(reader[0].ToString());
                Console.WriteLine(reader[1].ToString());
                Console.WriteLine(reader.GetDecimal(2));
                Console.WriteLine(reader.GetInt32(3));
            }
            execute.BaglantiKontrol();
        }
    }
}
