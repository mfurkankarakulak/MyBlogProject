using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using MyBlogProject.Entity.Models;

namespace MyBlogProject.Dal.Mapping
{
    public class ContentTypeMap : EntityTypeConfiguration<ContentType>
    {
        public ContentTypeMap()
        {
            ToTable("ContentType");

            this.HasKey<int>(u => u.Id);
            this.Property(u => u.ContentTypeName).IsRequired().HasColumnName("ContentTypeName").HasMaxLength(20);
        }
    }
}
