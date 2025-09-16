﻿using BaithuchanhWeb2.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace BaithuchanhWeb2.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> dbContextOptions) : base(dbContextOptions)
        {
            //constructor
        }
        //define C# model
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // có thể định nghĩa quan hệ giữa các table bằng Fluent API
            modelBuilder.Entity<Book_Author>().HasOne(ba => ba.Book)
                .WithMany(b => b.Book_Authors)
                .HasForeignKey(bi => bi.BookId);

            modelBuilder.Entity<Book_Author>().HasOne(b => b.Author)
                .WithMany(ba => ba.Book_Authors)
                .HasForeignKey(bi => bi.AuthorId);
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Authors> Authors { get; set; }
        public DbSet<Book_Author> Books_Authors { get; set; }
        public DbSet<Publishers> Publishers { get; set; }
    }
}
