using Dapper;
using DatabasePOC.Dapper.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using static Dapper.SqlBuilder;

namespace DatabasePOC.Dapper.Repository.Base
{
    public class RepositoryBase<T> : IRepository<T> where T : class
    {
        protected readonly string _connectionString;
        protected readonly IDapperExecutor _executor;

        protected readonly SqlBuilder _sqlBuilder;
        protected Template _selectTemplate;

        protected readonly string _tableSchema;
        protected readonly string _tableName;

        protected readonly string _fields;

        protected RepositoryBase(string connectionString, IDapperExecutor executor, string tableName, string tableSchema)
        {
            _connectionString = connectionString;
            _executor = executor;
            _tableName = tableName;
            _tableSchema = tableSchema;

            _sqlBuilder = new SqlBuilder();

            _fields = "*";
            _selectTemplate = _sqlBuilder.AddTemplate(
                $"select {_fields} from {_tableSchema}.{_tableName} /**innerjoin**/ /**where**/ /**orderby**/");
        }

        protected void AddInnerJoin(string joinSql)
        {
            _sqlBuilder.InnerJoin(joinSql);
        }

        protected void AddWhere(string clause, object paramz)
        {
            _sqlBuilder.Where(clause, paramz);
        }
    }

}
