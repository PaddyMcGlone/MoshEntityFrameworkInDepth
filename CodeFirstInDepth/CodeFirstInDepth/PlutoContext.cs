﻿using System.Data.Entity;

namespace CodeFirstInDepth
{
    public class PlutoContext : DbContext
    {
        public PlutoContext() 
            : base("name=DefaultConnection")
        {
        }

        public DbSet<Course> Courses { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Add Required attribute
            //modelBuilder.Entity<Course>()
            //    .Property(c => c.Description)
            //    .IsRequired();
        }
    }
}