using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabasePOC.EF.Repository.Base;

namespace DatabasePOC
{
    public class HorarioRepository : RepositoryBase<Disciplina>
    {
        public HorarioRepository(DatabasePOCContext db) : base(db)
        {
        }

        public IEnumerable<Horario> GetAllHorariosWithAll()
        {
            return Db.Horarios.AsNoTracking()
                                    .Include("Disciplinas")
                                    .Include("Turmas")
                                    .ToList();
                                    
        }

    }
}
