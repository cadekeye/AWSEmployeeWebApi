using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class SqlDataAccess : ISqlDataAccess
    {
        private readonly IConfiguration _configuration;
        private readonly string ConnectionStringName = "EmployeeConn";

        //private readonly string ConnectionStringName = "Default";
        private readonly string connectionString;

        public SqlDataAccess(IConfiguration configuration)
        {
            _configuration = configuration;
            connectionString = _configuration.GetConnectionString(ConnectionStringName);
        }

        public async Task<List<T>> LoadData<T, U>(string sql, U parameter)
        {
            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                var result = await connection.QueryAsync<T>(sql, parameter);

                return result.ToList();
            }
        }

        //public async Task<T> Insert<T>(string sql, T data)
        //{
        //    using (IDbConnection connection = new SqlConnection(connectionString))
        //    {
        //        await connection.ExecuteAsync(sql, data);

        //        return data;
        //    }
        //}

        //public async Task Delete<T>(string sql, T data)
        //{
        //    using (IDbConnection connection = new SqlConnection(connectionString))
        //    {
        //        await connection.ExecuteAsync(sql, data);
        //    }
        //}

        public async Task<T> ProcessData<T>(string sql, T data)
        {
            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                await connection.ExecuteAsync(sql, data);

                return data;
            }
        }
    }
}