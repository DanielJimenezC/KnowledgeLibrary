using Library.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Text;

namespace Library.Infrastructure.Configuration
{
    public class BookConfiguration : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasKey(b => b.Id);

            builder.Property(b => b.Id)
                .ValueGeneratedOnAdd()
                .UseIdentityColumn()
                .HasColumnName("id")
                .IsRequired();

            builder.Property(b => b.Code)
                .HasMaxLength(20)
                .HasColumnName("code")
                .IsRequired();

            builder.Property(b => b.Isbn)
                .HasColumnName("isbn")
                .IsRequired();

            builder.Property(b => b.Name)
                .HasMaxLength(60)
                .HasColumnName("name")
                .IsRequired();

            builder.Property(b => b.Description)
                .HasMaxLength(200)
                .HasColumnName("description")
                .IsRequired();

            builder.Property(b => b.Pages)
                .HasColumnName("pages")
                .IsRequired();

            builder.Property(b => b.PublishAt)
                .HasColumnName("publish_at")
                .IsRequired();

            builder.Property(b => b.EditorialId)
                .HasColumnName("editorial_id")
                .IsRequired();

            builder.Property(b => b.AuthorId)
                .HasColumnName("author_id")
                .IsRequired();

            builder.Property(b => b.PresentationId)
                .HasColumnName("presentation_id")
                .IsRequired();

            builder.Property(b => b.LanguageId)
                .HasColumnName("language_id")
                .IsRequired();

            builder.Property(b => b.CreateAt)
                .HasColumnName("create_at");

            builder.Property(b => b.ModifiedAt)
                .HasColumnName("modified_at");

            builder.HasOne<Author>(b => b.Author)
                .WithMany(b => b.Books)
                .HasForeignKey(b => b.AuthorId);
        }
    }
}
