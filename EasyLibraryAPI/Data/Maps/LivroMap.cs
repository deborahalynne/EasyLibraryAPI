using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using EasyLibraryAPI.Models;

namespace EasyLibraryAPI.Data.Maps
{
    public class LivroMap: IEntityTypeConfiguration<Livro>
    {
        public void Configure(EntityTypeBuilder<Livro> builder)
        {
            builder.ToTable("Livro");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Titulo).IsRequired().HasMaxLength(60).HasColumnType("varchar(60)");
            builder.Property(x => x.Autor).IsRequired().HasMaxLength(40).HasColumnType("varchar(40)");
            builder.Property(x => x.Secao).HasMaxLength(40).HasColumnType("varchar(40)");
            builder.Property(x => x.Valor).IsRequired().HasColumnType("money");
            builder.Property(x => x.Quantidade).IsRequired();
        }
    }
}
