using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using MyBlogProject.Entity.Models;

namespace MyBlogProject.Dal.Mapping
{
    public class ImageMap : EntityTypeConfiguration<Image>
    {
        public ImageMap()
        {
            ToTable("Image");

            this.HasKey<int>(u => u.Id);
            this.Property(u => u.ImageUrl).IsRequired().HasColumnName("ImageUrl").HasMaxLength(100);
        }
    }
}
