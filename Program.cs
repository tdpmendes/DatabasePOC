using Dapper;
using DatabasePOC.Dapper.Executor;
using DatabasePOC.Dapper.Repository;
using DatabasePOC.EF.Repository;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;

namespace DatabasePOC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Execuções EF
            DatabasePOCContext context = new DatabasePOCContext();
            
            AlunoRepository alunosEF = new AlunoRepository(context);
            TurmaRepository turmasEF = new TurmaRepository(context);
            DisciplinaRepository disciplinasEF = new DisciplinaRepository(context);
            ProfessorRepository professoresEF = new ProfessorRepository(context);
            HorarioRepository horariosEF = new HorarioRepository(context);
            
            var all = horariosEF.GetAllHorariosWithAll();
            var disciplinasP = disciplinasEF.GetDisciplinasWithProfessor();
            var profsD = professoresEF.GetProfessoresWithDisciplinas();


            //Execuções Dapper
            Dapper.Repository.AlunoRepository alunosDapper = 
                new Dapper.Repository.AlunoRepository(Constants.ConnectionString, new DapperExecutor());

            var aluno = alunosDapper.GetByNome("Adriano Borsato Cardoso");

         }
    }
}
