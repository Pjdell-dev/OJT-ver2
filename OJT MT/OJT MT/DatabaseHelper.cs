using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OJT_MT
{
    public class DatabaseHelper
    {
        private string _connectionString;
        private MySqlConnection? _connection;
        public DatabaseHelper(string server, string userId, string password, string database)
        {
            _connectionString = $"Server={server};User ID={userId};Password={password};Database={database}";
        }

        // Open connection if it's not already open
        private async Task<MySqlConnection> GetConnectionAsync()
        {
            if (_connection == null)
                _connection = new MySqlConnection(_connectionString);

            if (_connection.State != ConnectionState.Open)
                await _connection.OpenAsync();

            return _connection;
        }


        public async Task<MySqlDataReader> ExecuteReaderAsync(string query, params MySqlParameter[] parameters)
        {
            var cmd = new MySqlCommand(query, await GetConnectionAsync());
            if (parameters != null)
                cmd.Parameters.AddRange(parameters);

            return await cmd.ExecuteReaderAsync(CommandBehavior.CloseConnection);
        }


        // For insert/update/delete
        public async Task<int> ExecuteNonQueryAsync(string query, params MySqlParameter[] parameters)
        {
            using var cmd = new MySqlCommand(query, await GetConnectionAsync());
            if (parameters != null)
                cmd.Parameters.AddRange(parameters);

            return await cmd.ExecuteNonQueryAsync();
        }

        // For getting a scalar value
        public async Task<object> ExecuteScalarAsync(string query, params MySqlParameter[] parameters)
        {
            using var cmd = new MySqlCommand(query, await GetConnectionAsync());
            if (parameters != null)
                cmd.Parameters.AddRange(parameters);

            return await cmd.ExecuteScalarAsync();
        }
        public void Dispose()
        {
            if (_connection != null)
            {
                _connection.Dispose();
                _connection = null;
            }
        }
    }
}
