using System.Collections.Generic;
using System.Data.Entity;
using System.Threading.Tasks;

namespace DatabasePOC
{
    public class DisciplinaRepository : RepositoryBase<Disciplina>
    {
        public DisciplinaRepository(DatabasePOCContext db) : base(db)
        {
        }

        public async Task<IEnumerable<Disciplina>> GetDisciplinasWithProfessorAsync()
        {
            return await Db.Disciplinas.AsNoTracking()
                                       .Include("Professor")
                                       .ToListAsync();
        } 
    }
}
