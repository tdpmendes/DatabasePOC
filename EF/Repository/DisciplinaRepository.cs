using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace DatabasePOC
{
    public class DisciplinaRepository : RepositoryBase<Disciplina>
    {
        public DisciplinaRepository(DatabasePOCContext db) : base(db)
        {
        }

        public IEnumerable<Disciplina> GetDisciplinasWithProfessor()
        {
            return Db.Disciplinas.AsNoTracking()
                                       .Include("Professores")
                                       .ToList();
        } 
    }
}
