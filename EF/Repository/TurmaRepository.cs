using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DatabasePOC
{
    public class TurmaRepository : RepositoryBase<Turma>
    {
        public TurmaRepository(DatabasePOCContext db) : base(db)
        {
        }

        public async Task<IEnumerable<Turma>> GetAllTurmasWithAlunosAsync()
        {
            return await Db.Turmas.AsNoTracking()
                                  .Include(e => e.Alunos).ToListAsync();
        }
    }
}
