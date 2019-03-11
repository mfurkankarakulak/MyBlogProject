using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlogProject.Entity.Models
{
    public class Country
    {

        public int Id { get; set; }
        public string CoutryName { get; set; }
        public virtual ICollection<City> Citys { get; set; }

    }
}
