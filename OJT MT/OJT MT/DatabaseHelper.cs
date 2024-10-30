using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OJT_MT
{
    public class DatabaseHelper : IDisposable
    {
        private string _connectionString;
        private MySqlConnection? _connection;
        public DatabaseHelper()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        }

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
            try
            {
                using var cmd = new MySqlCommand(query, await GetConnectionAsync());
                if (parameters != null) cmd.Parameters.AddRange(parameters);
                return await cmd.ExecuteReaderAsync(CommandBehavior.CloseConnection);
            }
            catch (MySqlException ex)
            {
                throw new Exception("Error executing reader query", ex);
            }
        }


        //For insert/update/delete
        public async Task<int> ExecuteNonQueryAsync(string query, params MySqlParameter[] parameters)
        {
            try
            {
                using var cmd = new MySqlCommand(query, await GetConnectionAsync());
                if (parameters != null) cmd.Parameters.AddRange(parameters);
                return await cmd.ExecuteNonQueryAsync();
            }
            catch (MySqlException ex)
            {
                throw new Exception("Error executing non-query", ex);
            }
        }

        //For getting a scalar value
        public async Task<object> ExecuteScalarAsync(string query, params MySqlParameter[] parameters)
        {
            try
            {
                using var cmd = new MySqlCommand(query, await GetConnectionAsync());
                if (parameters != null)
                    cmd.Parameters.AddRange(parameters);
                    
                return await cmd.ExecuteScalarAsync();
            }
            catch (MySqlException ex)
            {
                throw new Exception("Error executing scalar query", ex);
            }
        }

        public async Task<bool> IsPasswordCorrectAsync(string userID, string password)
        {

            string query = "SELECT user_password FROM users WHERE user_id = @userID"; // Replace 'user_password' with your actual column name
            var result = await ExecuteScalarAsync(query, new MySqlParameter("@userID", userID));

            //Check if the result is null (user not found) or compare passwords
            return result != null && Convert.ToString(result) == password;
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
