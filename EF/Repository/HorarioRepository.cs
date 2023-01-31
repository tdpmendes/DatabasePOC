using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabasePOC
{
    public class HorarioRepository : RepositoryBase<Disciplina>
    {
        public HorarioRepository(DatabasePOCContext db) : base(db)
        {
        }

        public async Task<IEnumerable<Horario>> GetAllHorariosWithAllAsync()
        {
            return await Db.Horarios.AsNoTracking()
                                    .Include(h => h.Disciplina)
                                    .Include(h => h.Turma)
                                    .ToListAsync();
        }

    }
}
