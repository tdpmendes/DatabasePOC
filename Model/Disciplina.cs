using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatabasePOC
{
    public class Disciplina : EntityBase
    {
        public virtual ICollection<Horario> Horarios { get; set; }

        public long? ProfessorId { get; set; } 

        [ForeignKey("ProfessorId")]
        public virtual Professor Professor { get; set; }
        public ICollection<Professor> Professores { get; set; }
    }
}
