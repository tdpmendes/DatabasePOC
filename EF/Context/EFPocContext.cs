using DatabasePOC;
using System.Data.Entity;

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

       
    }
}
