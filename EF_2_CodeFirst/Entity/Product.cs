using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_2_CodeFirst.Entity
{
    internal class Product
    {
        public int Id { get; set; }

        [MaxLength(30)]
        public string Name { get; set; }

        public double Price { get; set; }

        public int Stock { get; set; }

        //OneToOne
        public int BarcodeId { get; set; }
        public Barcode Barcode { get; set; }

        //OneToMany
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
