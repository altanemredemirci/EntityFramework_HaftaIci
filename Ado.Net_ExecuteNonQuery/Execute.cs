using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ado.Net_ExecuteNonQuery
{
    internal class Execute
    {
        SqlConnection connect;
        SqlCommand cmd;
        public Execute()
        {
            connect = new SqlConnection("Server=DESKTOP-58CMK8T\\SQLDERS;Database=AdoNetDB; Integrated Security=true; TrustServerCertificate=true");
        }
        public int Insert()
        {
            cmd = new SqlCommand("Insert into Products values ('Elma',150.45,500)", connect);

            connect.Open();

            //ExecuteNonQuery: DML(Data Manipulation Language- Insert,Update,Delete) komutlarını kullarak datayı manipüle ediyorsak kullanılır.
            int EKS = cmd.ExecuteNonQuery();

            connect.Close();

            return EKS;
        }

        public int InsertParams(Product P)
        {
           cmd = new SqlCommand($"Insert into Products values ('{P.Name}',{P.Price},{P.Stock})", connect);

            connect.Open();

            //ExecuteNonQuery: DML(Data Manipulation Language- Insert,Update,Delete) komutlarını kullarak datayı manipüle ediyorsak kullanılır.
            int EKS = cmd.ExecuteNonQuery();

            connect.Close();

            return EKS;
        }
    }
}
