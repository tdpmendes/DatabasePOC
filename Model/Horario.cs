using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatabasePOC
{
    public class Horario : EntityBase
    {
        [Column("turma_id")]
        public long TurmaId { get; set; }

        [ForeignKey("TurmaId")] 
        public virtual Turma Turma { get; set; }

        [Column("disciplina_id")]
        public long DisciplinaId { get; set; }

        [ForeignKey("DisciplinaId")] 
        public virtual Disciplina Disciplina { get; set; }

        [Column("InicioHorario")]
        public TimeSpan InicioHorario { get; set; }

        [Column("FimHorario")]
        public TimeSpan FimHorario { get; set; }

        [Column("GerarAlerta")]
        public bool GerarAlerta { get; set; }

    }

}
