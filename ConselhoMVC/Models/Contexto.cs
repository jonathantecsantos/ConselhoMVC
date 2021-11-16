using Microsoft.EntityFrameworkCore;

namespace ConselhoMVC.Models
{
    public class Contexto : DbContext
    {
        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Disciplina> Disciplinas { get; set; }
        public DbSet<Turma> Turma { get; set; }
        public DbSet<Professor> Professor { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString: @"Server=(localdb)\mssqllocaldb;Database=Conselho;Database=master;Trusted_Connection=True;");
        }
    }
}
