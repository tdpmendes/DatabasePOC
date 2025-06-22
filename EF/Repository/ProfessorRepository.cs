using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using DatabasePOC.EF.Repository.Base;

namespace DatabasePOC
{
    public class ProfessorRepository : RepositoryBase<Professor>
    {
        public ProfessorRepository(DatabasePOCContext db) : base(db)
        {

        }

        public IEnumerable<Professor> GetProfessoresWithDisciplinas()
        {
            return Db.Professores.AsNoTracking()
                                       .Include("Disciplina")
                                       .ToList();
                                       
        }
    }
}
