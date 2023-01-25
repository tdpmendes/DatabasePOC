using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EFPoc
{
    public class DisciplinaRepository : RepositoryBase<Disciplina>
    {
        public DisciplinaRepository(EFPocContext db) : base(db)
        {
        }

        public async Task<IEnumerable<Disciplina>> GetDisciplinasWithProfessorAsync()
        {
            return await Db.Disciplinas.AsNoTracking()
                                       .Include(e => e.Professor)
                                       .ToListAsync();
        } 
    }
}
