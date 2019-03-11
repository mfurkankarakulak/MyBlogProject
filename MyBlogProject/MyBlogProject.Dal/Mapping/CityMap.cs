using MyBlogProject.Entity.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlogProject.Dal.Mapping
{
    public class CityMap : EntityTypeConfiguration<City>
    {
        public CityMap()
        {
            ToTable("City");

            this.HasKey<int>(u => u.Id);
            this.Property(u => u.CountryId).IsRequired().HasColumnName("CountryId");
            this.Property(u => u.CityName).IsRequired().HasColumnName("CityName").HasMaxLength(50);


        }
    }
}
