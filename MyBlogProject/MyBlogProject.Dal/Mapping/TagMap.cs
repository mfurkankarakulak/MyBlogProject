using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using MyBlogProject.Entity.Models;

namespace MyBlogProject.Dal.Mapping
{
    public class TagMap : EntityTypeConfiguration<Tag>
    {
        public TagMap()
        {
            ToTable("Tag");

            this.HasKey<int>(u => u.Id);
            this.Property(u => u.TagName).IsRequired().HasColumnName("TagName").HasMaxLength(20);

        }
    }
}
