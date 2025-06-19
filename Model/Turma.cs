using System.Collections.Generic;

namespace DatabasePOC
{
    public class Turma : EntityBase
    {
        public virtual ICollection<Horario> Horarios { get; set; }

        public virtual IList<Aluno> Alunos { get; set; }
    }
}
