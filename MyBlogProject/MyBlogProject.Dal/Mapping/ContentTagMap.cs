using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using MyBlogProject.Entity.Models;
using MyBlogProject.Dal.Mapping;

namespace MyBlogProject.Dal.Mapping
{
    public class ContentTagMap : EntityTypeConfiguration<ContentTag>
    {
        public ContentTagMap()
        {
            ToTable("ContentTag");

            this.HasKey<int>(u => u.Id);
            this.Property(u => u.ContentId).IsRequired().HasColumnName("ContentId");
            this.Property(u => u.TagId).IsRequired().HasColumnName("TagId");
        }
    }
}
