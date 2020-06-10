using Library.Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Library.Infrastructure.Configuration
{
    public class AuthorConfigurations : IEntityTypeConfiguration<Author>
    {
        public void Configure(EntityTypeBuilder<Author> builder)
        {
            builder.HasKey(a => a.Id);

            builder.Property(a => a.Id)
                .ValueGeneratedOnAdd()
                .UseIdentityColumn()
                .HasColumnName("id")
                .IsRequired();

            builder.Property(a => a.Name)
                .HasMaxLength(50)
                .HasColumnName("name")
                .IsRequired();

            builder.Property(a => a.CreateAt)
                .HasColumnName("create_at");

            builder.Property(a => a.ModifiedAt)
                .HasColumnName("modified_at");
        }
    }
}
