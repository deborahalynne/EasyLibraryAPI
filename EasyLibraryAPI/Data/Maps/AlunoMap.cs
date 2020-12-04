using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using EasyLibraryAPI.Models;
namespace EasyLibraryAPI.Data.Maps
{
    public class AlunoMap : IEntityTypeConfiguration<Aluno>
    {
        public void Configure(EntityTypeBuilder<Aluno> builder)
        {
            builder.ToTable("Aluno");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Nome).IsRequired().HasMaxLength(60).HasColumnType("varchar(60)");
            builder.Property(x => x.DataNascimento).IsRequired();
            builder.Property(x => x.Curso).IsRequired().HasMaxLength(60).HasColumnType("varchar(60)");
            builder.Property(x => x.Cpf).IsRequired().HasMaxLength(11).HasColumnType("char(11)");
            builder.Property(x => x.Rg).IsRequired().HasMaxLength(11).HasColumnType("char(9)");
            builder.Property(x => x.Celular).IsRequired().HasMaxLength(11).HasColumnType("char(11)");
            builder.Property(x => x.Email).IsRequired().HasMaxLength(60).HasColumnType("varchar(60)");
            builder.Property(x => x.Cep).IsRequired().HasMaxLength(8).HasColumnType("char(8)");
            builder.Property(x => x.Endereco).IsRequired().HasMaxLength(80).HasColumnType("varchar(80)");
            builder.Property(x => x.Endnum).IsRequired().HasMaxLength(4).HasColumnType("char(4)");


        }
         
    }
}
