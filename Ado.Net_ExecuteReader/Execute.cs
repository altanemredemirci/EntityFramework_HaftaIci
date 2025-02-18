using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ado.Net_ExecuteReader
{
    internal class Execute
    {
        SqlConnection connect;
        SqlCommand cmd;
        public Execute()
        {
            connect = new SqlConnection("Server=DESKTOP-58CMK8T\\SQLDERS;Database=AdoNetDB; Integrated Security=true; TrustServerCertificate=true");
        }
        
        public SqlDataReader Select(string name = null)
        {
            if (name == null)
            {
                cmd = new SqlCommand("Select * from Products", connect);
            }
            else
            {
                cmd = new SqlCommand($"Select * from Products Where Name={name}", connect);
            }
            BaglantiKontrol();
            SqlDataReader reader = cmd.ExecuteReader();
           
            return reader;
        }


        public void BaglantiKontrol()
        {
            if(connect.State== ConnectionState.Open)
            {
                connect.Close();
            }
            else
            {
                connect.Open();
            }
        }
    }
}
