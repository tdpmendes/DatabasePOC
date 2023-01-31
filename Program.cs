using DatabasePOC;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Data.Common;

namespace DatabasePOC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Execuções EF
            /*
            DatabasePOCContext context = new DatabasePOCContext();

            AlunoRepository alunos = new AlunoRepository(context);
            TurmaRepository turmas = new TurmaRepository(context);
            DisciplinaRepository disciplinas = new DisciplinaRepository(context);
            ProfessorRepository professores = new ProfessorRepository(context);
            HorarioRepository horarios = new HorarioRepository(context);

            var all = horarios.GetAllHorariosWithAllAsync().Result;
            var disciplinasP = disciplinas.GetDisciplinasWithProfessorAsync().Result;
            var profsD = professores.GetProfessoresWithDisciplinasAsync().Result;
            */

            //Execuções Dapper
            IDbConnection connection = new SqlConnection(Constants.ConnectionString);

         }
    }
}
