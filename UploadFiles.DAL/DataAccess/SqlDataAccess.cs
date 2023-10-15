using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Data;
using System.Threading.Tasks;

namespace UploadFiles.DAL.DataAccess
{
    public class SqlDataAccess : ISqlDataAccess
    {
        private readonly string _connectionString;

        public SqlDataAccess(IConfiguration config)
        {
            _connectionString = config.GetConnectionString(DataAccessConsts.DefaultConnectionStringName) ??
                throw new Exception($"Missing connection string at {DataAccessConsts.DefaultConnectionStringName}");
        }

        public async Task SaveDataAsync(
            string storedProcedure,
            object parameters)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                await connection.ExecuteAsync(storedProcedure, parameters, commandType: CommandType.StoredProcedure);
            }
        }
    }
}
