using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_2_CodeFirst_2
{
    internal class Ogrenci
    {
        public int Id { get; set; }
        public int Numara { get; set; }
        public string Ad { get; set; }

        public int SinifId { get; set; }
        public Sinif Sinif { get; set; }
    }
}
