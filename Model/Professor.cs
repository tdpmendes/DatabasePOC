using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatabasePOC
{
    public class Professor : EntityBase
    {
        public decimal Salario { get; set; }

        [Column("disciplina_id")]
        public long DisciplinaId { get; set; }

        public Disciplina Disciplina { get; set; }

        public ICollection<Disciplina> Disciplinas { get; set; }
    }
}
