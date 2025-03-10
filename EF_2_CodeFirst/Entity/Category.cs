﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_2_CodeFirst.Entity
{
    internal class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        //OneToMany
        public List<Product> Products { get; set; }

        //ManyToMany
        public List<BrandCategory> BrandCategories { get; set; }
    }
}
