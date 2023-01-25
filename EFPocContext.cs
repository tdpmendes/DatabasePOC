using Microsoft.EntityFrameworkCore;

namespace EFPoc
{
    public class EFPocContext : DbContext
    {
        public virtual DbSet<Aluno> Alunos { get; set; }
        public virtual DbSet<Disciplina> Disciplinas{ get; set; }
        public virtual DbSet<Horario> Horarios { get; set; }
        public virtual DbSet<Professor> Professores { get; set; }
        public virtual DbSet<Turma> Turmas { get; set; }

        public EFPocContext()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Sempre conferir se a connection string bate com a sua configuracao
            optionsBuilder.UseSqlServer("Server=tcp:localhost,1433; Initial Catalog=EFPoc; User ID=sa;Password=@dm1n1str@t0r");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<EFPoc>(entity =>
            //{
            //
            //});

        }
    }
}
