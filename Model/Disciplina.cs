using System.ComponentModel.DataAnnotations.Schema;

namespace DatabasePOC
{
    public class Disciplina : EntityBase
    {
        //[Column("professor_id")]
        //public long ProfessorId { get; set; }

        public Professor Professor { get; set; }

    }
}
