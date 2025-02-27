using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_2_CodeFirst_2
{
    internal class Sinif
    {
        public int Id { get; set; }
        public string Ad { get; set; }

        public List<Ogrenci> Ogrencis { get; set; }
    }
}
