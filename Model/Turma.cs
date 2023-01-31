using System.Collections.Generic;

namespace DatabasePOC
{
    public class Turma : EntityBase
    {
        public IList<Aluno> Alunos { get; set; }
    }
}
