using System.Collections.Generic;

namespace EFPoc
{
    public class Turma : EntityBase
    {
        public IList<Aluno> Alunos { get; set; }
    }
}
