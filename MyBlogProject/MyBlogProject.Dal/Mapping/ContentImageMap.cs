using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using MyBlogProject.Entity.Models;

namespace MyBlogProject.Dal.Mapping
{
    public class ContentImageMap : EntityTypeConfiguration<ContentImage>
    {
        public ContentImageMap()
        {
            ToTable("ContentImage");
            this.HasKey<int>(u => u.Id);
            this.Property(u => u.ImageId).IsRequired().HasColumnName("ImageId");
            this.Property(u => u.ContentId).IsRequired().HasColumnName("ContentId");
        }
    }
}
