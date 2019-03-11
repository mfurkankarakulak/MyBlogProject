using MyBlogProject.Dal.Mapping;
using MyBlogProject.Dal.Migrations;
using MyBlogProject.Entity.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlogProject.Dal.Context
{
    public class MyBlogContext :DbContext
    {
        public MyBlogContext()
            : base("MyBlogContext")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<MyBlogContext, Configuration>());
        }
        public DbSet<User> User { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<Country> Country { get; set; }
        public DbSet<City> City { get; set; }
        public DbSet<Content> Content { get; set; }
        public DbSet<ContentType> ContentType { get; set; }
        public DbSet<Image> Image { get; set; }
        public DbSet<Tag> Tag { get; set; }
        public DbSet<ContentTag> ContentTag { get; set; }
        public DbSet<ContentImage> ContentImage { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CityMap());
            modelBuilder.Configurations.Add(new CountryMap());
            modelBuilder.Configurations.Add(new ContentMap());
            modelBuilder.Configurations.Add(new ContentTagMap());
            modelBuilder.Configurations.Add(new ContentTypeMap());
            modelBuilder.Configurations.Add(new ContentImageMap());
            modelBuilder.Configurations.Add(new ImageMap());
            modelBuilder.Configurations.Add(new RoleMap());
            modelBuilder.Configurations.Add(new TagMap());
            modelBuilder.Configurations.Add(new UserMap());

            base.OnModelCreating(modelBuilder);
        }
    }
}
