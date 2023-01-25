using System.ComponentModel.DataAnnotations.Schema;

namespace EFPoc
{
    public class Professor : EntityBase
    {
        public decimal Salario { get; set; }

        [Column("disciplina_id")]
        public long DisciplinaId { get; set; }

        public Disciplina Disciplina { get; set; }
    }
}
