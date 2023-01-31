using DatabasePOC;
using Microsoft.EntityFrameworkCore;

namespace DatabasePOC
{
    public class DatabasePOCContext : DbContext
    {
        public virtual DbSet<Aluno> Alunos { get; set; }
        public virtual DbSet<Disciplina> Disciplinas { get; set; }
        public virtual DbSet<Horario> Horarios { get; set; }
        public virtual DbSet<Professor> Professores { get; set; }
        public virtual DbSet<Turma> Turmas { get; set; }

        public DatabasePOCContext()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Sempre conferir se a connection string bate com a sua configuracao
            optionsBuilder.UseSqlServer(Constants.ConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<DatabasePOC>(entity =>
            //{
            //
            //});

            //modelBuilder.Entity<Aluno>().HasBaseType<EntityBase>();
            //modelBuilder.Entity<Turma>().HasBaseType<EntityBase>();
            //modelBuilder.Entity<Professor>().HasBaseType<EntityBase>();
            //modelBuilder.Entity<Horario>().HasBaseType<EntityBase>();
            //modelBuilder.Entity<Disciplina>().HasBaseType<EntityBase>();

            //modelBuilder.Entity<Professor>().HasOne<Disciplina>();
            //modelBuilder.Entity<Disciplina>().HasOne<Professor>();

            //modelBuilder.Entity<Professor>().HasOne<Disciplina>();
            //modelBuilder.Entity<Disciplina>().HasOne<Professor>();

            //modelBuilder.Entity<Disciplina>(d => d.OwnsOne(p => p.Professor));

            //modelBuilder.Entity<Disciplina>(b =>
            //{
            //    b.OwnsOne(e => e.Professor);
            //    b.Navigation(e => e.Professor);
            //});

            modelBuilder.Entity<Turma>()
                            .HasMany(m => m.Alunos)
                            .WithOne()
                            .HasForeignKey(m => m.TurmaId);

        }
    }
}
