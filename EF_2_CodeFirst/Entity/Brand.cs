using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_2_CodeFirst.Entity
{
    internal class Brand
    {
        public int Id { get; set; }
        public string Name { get; set; }

        //ManyToMany
        public List<BrandCategory> BrandCategories { get; set; }

    }
}
