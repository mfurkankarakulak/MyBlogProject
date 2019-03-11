using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using MyBlogProject.Entity.Models;

namespace MyBlogProject.Dal.Mapping
{
    public class CountryMap : EntityTypeConfiguration<Country>
    {
        public CountryMap()
        {
            ToTable("Country");

            this.HasKey<int>(u => u.Id);
            this.Property(u => u.CoutryName).IsRequired().HasColumnName("CoutryName").HasMaxLength(100);
        }
    }
}
