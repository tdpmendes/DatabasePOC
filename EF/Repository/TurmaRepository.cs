using System.Collections.Generic;
using System.Data.Entity;
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
                                  .Include("Alunos")
                                  .ToListAsync();
        }
    }
}
