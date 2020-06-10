using Library.Domain.Entities;
using Library.Infrastructure.Configuration;
using Microsoft.EntityFrameworkCore;
using System;

namespace Library.Infrastructure.Context
{
    public class PostgreSqlContext : DbContext
    {
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<BookGenre> BookCategories { get; set; }
        public DbSet<Genre> Categories { get; set; }
        public DbSet<Editorial> Editorials { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<Presentation> Presentations { get; set; }

        public PostgreSqlContext(DbContextOptions<PostgreSqlContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new AuthorConfigurations());
            builder.ApplyConfiguration(new BookConfiguration());
        }
    }
}
