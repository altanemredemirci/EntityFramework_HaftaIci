using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_2_CodeFirst.Entity
{
    internal class Barcode
    {
        public int Id { get; set; }
        public string Code { get; set; }


        //OneToOne
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
