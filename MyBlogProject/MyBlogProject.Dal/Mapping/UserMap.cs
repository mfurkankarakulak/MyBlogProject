using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using MyBlogProject.Entity.Models;

namespace MyBlogProject.Dal.Mapping
{
    public class UserMap : EntityTypeConfiguration<User>
    {
        public UserMap()
        {
            this.ToTable("User");
            this.HasKey<int>(p => p.Id);
            this.Property(u => u.Name).IsRequired().HasColumnName("Name").HasMaxLength(50);
            this.Property(u => u.SurName).IsRequired().HasColumnName("SurName").HasMaxLength(50);
            this.Property(u => u.EMailAdress).IsRequired().HasColumnName("EmailAdress").HasMaxLength(50);
            this.Property(u => u.Password).IsRequired().HasColumnName("Password").HasMaxLength(18);
            this.Property(u => u.Password2).IsRequired().HasColumnName("Password2").HasMaxLength(18);
            this.Property(u => u.PhoneNumber).IsRequired().HasColumnName("PhoneNumber").HasMaxLength(20);
            this.Property(u => u.RoleId).IsRequired().HasColumnName("RoleId");
            this.Property(u => u.CountryId).IsRequired().HasColumnName("CountryId");
            this.Property(u => u.CityId).IsRequired().HasColumnName("CityId");
            this.Property(u => u.TryPasswordCount).IsRequired().HasColumnName("TryPasswordCount");
            this.Property(u => u.RegisterTime).IsRequired().HasColumnName("RegisterTime");

        }
    }
}
