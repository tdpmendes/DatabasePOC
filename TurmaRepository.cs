using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EFPoc
{
    public class TurmaRepository : RepositoryBase<Turma>
    {
        public TurmaRepository(EFPocContext db) : base(db)
        {
        }

        public async Task<IEnumerable<Turma>> GetAllTurmasWithAlunosAsync()
        {
            return await Db.Turmas.AsNoTracking()
                                  .Include(e => e.Alunos).ToListAsync();
        }
    }
}
