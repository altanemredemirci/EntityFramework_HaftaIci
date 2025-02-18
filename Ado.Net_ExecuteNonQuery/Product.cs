using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ado.Net_ExecuteNonQuery
{
    internal class Product
    {   
        // Primary Key ve Identity attributelerini tanımladım
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [StringLength(20)]
        public string Name { get; set; }

        public double Price { get; set; }

        [Range(1,1000)]
        public int Stock { get; set; }
    }
}
