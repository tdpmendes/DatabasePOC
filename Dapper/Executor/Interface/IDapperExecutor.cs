using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabasePOC.Dapper.Executor.Interface
{
    public interface IDapperExecutor
    {
        T QueryFirstOrDefault<T>(IDbConnection connection, string sql, object param = null);
        IEnumerable<T> Query<T>(IDbConnection connection, string rawSql, object parameters);
    }
}
