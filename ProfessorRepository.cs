using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EFPoc
{
    public class ProfessorRepository : RepositoryBase<Professor>
    {
        public ProfessorRepository(EFPocContext db) : base(db)
        {

        }

        public async Task<IEnumerable<Professor>> GetProfessoresWithDisciplinasAsync()
        {
            return await Db.Professores.AsNoTracking()
                                       .Include(e => e.Disciplina)
                                       .ToListAsync();
        }
    }
}
