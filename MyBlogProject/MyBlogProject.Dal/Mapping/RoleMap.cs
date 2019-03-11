using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using MyBlogProject.Entity.Models;

namespace MyBlogProject.Dal.Mapping
{
    public class RoleMap : EntityTypeConfiguration<Role>
    {
        public RoleMap()
        {
            ToTable("Role");

            this.HasKey<int>(u => u.Id);
            this.Property(u => u.RoleName).IsRequired().HasColumnName("RoleName").HasMaxLength(20);

        }
    }
}
