using DatabasePOC.EF.Repository.Base;

namespace DatabasePOC
{
    public class AlunoRepository : RepositoryBase<Aluno>
    {
        public AlunoRepository(DatabasePOCContext db) : base(db)
        {
        }
    }
}
