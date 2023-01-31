using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatabasePOC
{
    public class Aluno : EntityBase
    {
        [ForeignKey("TurmaId")]
        [Column("turma_id")]
        public long TurmaId { get; set; }
        [Column("matricula")]
        public Guid Matricula { get; set; }
        [Column("dataNascimento")]
        public DateTime DataNascimento { get; set; }
        [Column("altura")]
        public double Altura { get; set; }
    }

}
