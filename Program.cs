using Dapper;
using DatabasePOC;
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
            
            AlunoRepository alunos = new AlunoRepository(context);
            TurmaRepository turmas = new TurmaRepository(context);
            DisciplinaRepository disciplinas = new DisciplinaRepository(context);
            ProfessorRepository professores = new ProfessorRepository(context);
            HorarioRepository horarios = new HorarioRepository(context);
            
            var all = horarios.GetAllHorariosWithAll();
            var disciplinasP = disciplinas.GetDisciplinasWithProfessor();
            var profsD = professores.GetProfessoresWithDisciplinas();


            //Execuções Dapper
            //IDbConnection connection = new SqlConnection(Constants.ConnectionString);
            //var result = connection.Query<Aluno>("Select * from alunos").ToList();

         }
    }
}
