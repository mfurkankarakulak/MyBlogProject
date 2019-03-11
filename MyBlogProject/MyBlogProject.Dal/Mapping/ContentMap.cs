using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using MyBlogProject.Entity.Models;

namespace MyBlogProject.Dal.Mapping
{
    public class ContentMap : EntityTypeConfiguration<Content>
    {
        public ContentMap()
        {
            ToTable("Content");

            this.HasKey<int>(u => u.Id);
            this.Property(u => u.ContentHeader).IsRequired().HasColumnName("ContentHeader").HasMaxLength(50);
            this.Property(u => u.ContentBody).IsRequired().HasColumnName("ContentBody").HasMaxLength(2000);
            this.Property(u => u.ContentTypeId).IsRequired().HasColumnName("ContentTypeId");
            this.Property(u => u.ContentImageId).IsRequired().HasColumnName("ContentImageId");
            this.Property(u => u.ContentTagId).IsRequired().HasColumnName("ContentTagId");


        }
    }
}
