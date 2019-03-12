using MyBlogProject.Entity.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlogProject.Dal.Mapping
{
    public class SexMap : EntityTypeConfiguration<Sex>
    {
        public SexMap()
        {
            ToTable("Sex");

            this.HasKey<int>(u => u.Id);
            this.Property(u => u.SexGender).HasColumnName("CountryId");
         
        }
    }
}
