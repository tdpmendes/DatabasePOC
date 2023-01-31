using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFPoc
{
    public class AlunoRepository : RepositoryBase<Aluno>
    {
        public AlunoRepository(EFPocContext db) : base(db)
        {
        }
    }
}
