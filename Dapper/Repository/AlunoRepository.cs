using DatabasePOC.Dapper.Executor.Interface;
using DatabasePOC.Dapper.Repository.Base;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabasePOC.Dapper.Repository
{
    public class AlunoRepository : RepositoryBase<Aluno>
    {
        public AlunoRepository(
            string connectionString, 
            IDapperExecutor executor, 
            string tableName = "[Alunos]",
            string tableSchema = "[dbo]") : base(connectionString, executor, tableName, tableSchema)
        {

        }

        public IList<Aluno> GetByNome(string nome)
        {
            var alunos = new List<Aluno>();

            using(var connection = new SqlConnection(_connectionString))
            {
                try
                {
                    AddWhere("nome = @nome", new { nome = nome });
                    alunos = _executor.Query<Aluno>(
                        connection,
                        _selectTemplate.RawSql,
                        _selectTemplate.Parameters
                        ).ToList();
                }
                catch (Exception ex) 
                {
                    throw ex;
                }
                finally
                {
                    connection.Close();
                }
            }
            return alunos;
        }
    }
}
