﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlogProject.Entity.Models
{
    public class City
    {

        public int Id { get; set; }
        public string CityName { get; set; }
        public int CountryId { get; set; }
    }
}
