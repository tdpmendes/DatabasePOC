namespace EFPoc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EFPocContext context = new EFPocContext();

            AlunoRepository alunos = new AlunoRepository(context);
            TurmaRepository turmas = new TurmaRepository(context);
            DisciplinaRepository disciplinas = new DisciplinaRepository(context);
            ProfessorRepository professores = new ProfessorRepository(context);
            HorarioRepository horarios = new HorarioRepository(context);

            var all = horarios.GetAllHorariosWithAllAsync().Result;

            //var disciplinasP = disciplinas.GetDisciplinasWithProfessorAsync().Result;
            //var profsD = professores.GetProfessoresWithDisciplinasAsync().Result;
        }
    }
}
