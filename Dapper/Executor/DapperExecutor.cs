using Dapper;
using System.Collections.Generic;
using System.Data;

namespace DatabasePOC.Dapper.Executor
{
    public class DapperExecutor
    {
        public T QueryFirstOrDefault<T>(IDbConnection connection, string sql, object param = null)
        {
            return connection.QueryFirstOrDefault<T>(sql, param);
        }

        public IEnumerable<T> Query<T>(IDbConnection connection, string rawSql, object parameters)
        {
            return connection.Query<T>(rawSql, parameters);
        }
    }
}
