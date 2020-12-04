using EasyLibraryAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace EasyLibraryAPI.Data
{
    public class Context : DbContext
    {
        public DbSet<Livro> Livros { get; set; }
        public DbSet<Aluno> Alunos { get; set; } 


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Password = admin123; Persist Security Info = True; User ID = sa; Initial Catalog = el2; Data Source = localhost\\SQLEXPRESS");
        }
    }
}
