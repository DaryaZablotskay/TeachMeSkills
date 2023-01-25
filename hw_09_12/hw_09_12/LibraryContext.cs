using hw_09_12.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hw_09_12
{
    public class LibraryContext : DbContext
    {
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserBook> UserBooks { get; set; }

        public LibraryContext(DbContextOptions<LibraryContext> context) : base(context)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>()
                .HasOne(x => x.Author)
                .WithMany(y => y.Books)
                .HasForeignKey(x => x.AuthorId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<UserBook>()
                .HasOne(x => x.User)
                .WithMany(y => y.UserBooks)
                .HasForeignKey(x => x.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<UserBook>()
               .HasOne(x => x.Book)
               .WithMany(y => y.UserBooks)
               .HasForeignKey(x => x.BookId)
               .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<UserBook>()
                .HasIndex(x => new { x.BookId, x.UserId }).IsUnique();

            modelBuilder.Entity<UserBook>()
                .HasKey(x => x.UserBookId);

            modelBuilder.Entity<Book>()
                .Property(x => x.Name)
                .HasMaxLength(255);

            modelBuilder.Entity<Author>()
                .Property(x => x.FirstName)
                .HasMaxLength(255);

            modelBuilder.Entity<Author>()
                .Property(x => x.LastName)
                .HasMaxLength(255);

            modelBuilder.Entity<Author>()
                .Property(x => x.Country)
                .HasMaxLength(255);

            modelBuilder.Entity<User>()
                .Property(x => x.FirstName)
                .HasMaxLength(255);

            modelBuilder.Entity<User>()
               .Property(x => x.LastName)
               .HasMaxLength(255);

            modelBuilder.Entity<User>()
               .Property(x => x.Email)
               .HasMaxLength(255);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-C122T4K;Database=EFLibrary;Trusted_Connection=True;");
        }
    }
}
