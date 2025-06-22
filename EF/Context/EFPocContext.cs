using DatabasePOC;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Reflection.Emit;

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
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder
                    .UseSqlServer(Constants.ConnectionString);
            }

            base.OnConfiguring(optionsBuilder);

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<DatabasePOC>(entity =>
            //{
            //
            //});

            modelBuilder.Ignore<EntityBase>();

            modelBuilder.Entity<Aluno>().ToTable("Alunos");
            modelBuilder.Entity<Turma>().ToTable("Turmas");
            modelBuilder.Entity<Professor>().ToTable("Professores");
            modelBuilder.Entity<Horario>().ToTable("Horarios");
            modelBuilder.Entity<Disciplina>().ToTable("Disciplinas");

            // Horario → Turma
            modelBuilder.Entity<Horario>()
              .HasOne(h => h.Turma)
              .WithMany(t => t.Horarios)
              .HasForeignKey(h => h.TurmaId);

            // Horario → Disciplina
            modelBuilder.Entity<Horario>()
              .HasOne(h => h.Disciplina)
              .WithMany(d => d.Horarios)
              .HasForeignKey(h => h.DisciplinaId);

            // Professor → Disciplina (1:N)
            modelBuilder.Entity<Professor>()
              .HasOne(p => p.Disciplina)
              .WithMany(d => d.Professores)       // em Disciplina: ICollection<Professor> Professores { get; set; }
              .HasForeignKey(p => p.DisciplinaId);

            modelBuilder.Entity<Disciplina>(b =>
            {
                b.ToTable("Disciplinas");
                b.HasKey(d => d.Id);

                // mapeia coluna física
                b.Property(d => d.ProfessorId)
                 .HasColumnName("professor_id");

                // relacionamento
                b.HasOne(d => d.Professor)
                 .WithMany(p => p.Disciplinas)
                 .HasForeignKey(d => d.ProfessorId)
                 .OnDelete(DeleteBehavior.Restrict);
            });



            /*
            modelBuilder.Entity<Professor>().HasOne<Disciplina>();
            modelBuilder.Entity<Disciplina>().HasOne<Professor>();
            modelBuilder.Entity<Disciplina>(d => d.OwnsOne(p => p.Professor));

            modelBuilder.Entity<Disciplina>(b =>
            {
                b.OwnsOne(e => e.Professor);
                b.Navigation(e => e.Professor);
            });
            modelBuilder.Entity<Turma>()
                            .HasMany(m => m.Alunos)
                            .WithOne()
                            .HasForeignKey(m => m.TurmaId);
            */

            base.OnModelCreating(modelBuilder);

        }
    }
}
