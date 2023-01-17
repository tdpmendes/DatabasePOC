namespace EFPoc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EFPocContext context = new EFPocContext();

            AlunoRepository alunos = new AlunoRepository(context);

            var all = alunos.GetAllAsync().Result;


            
        }
    }
}
