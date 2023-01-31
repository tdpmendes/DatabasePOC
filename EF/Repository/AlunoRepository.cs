namespace DatabasePOC
{
    public class AlunoRepository : RepositoryBase<Aluno>
    {
        public AlunoRepository(DatabasePOCContext db) : base(db)
        {
        }
    }
}
