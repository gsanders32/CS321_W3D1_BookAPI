using System;
using CS321_W3D1_BookAPI.Models;
using Microsoft.EntityFrameworkCore;
namespace CS321_W3D1_BookAPI.Data
{
    public class BookContext : DbContext
    {
        // TODO: implement a DbSet<Book> property
        public DbSet<Book> Books { get; set; }
        // This method runs once when the DbContext is first used.
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // TODO: use optionsBuilder to configure a Sqlite db
            optionsBuilder.UseSqlite("Data Source=Books.db");
        }

        // This method runs once when the DbContext is first used.
        // It's a place where we can customize how EF Core maps our
        // model to the database. 
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // TODO: configure some seed data in the books table
            modelBuilder.Entity<Book>().HasData(
            new Book { Id = 1, Title = "Nineteen Eighty-Four", Author = "George Orwell", Category = "Fiction" },
            new Book { Id = 2, Title = "Educated", Author = "Tara Westover", Category = "Non-fiction" },
            new Book { Id = 3, Title = "It", Author = "Stephen King", Category = "Horror" }
            );
        }

    }
}

