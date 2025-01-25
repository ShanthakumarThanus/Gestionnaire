using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;
using Dapper;
using System.Data;

namespace Gestionnaire
{
    public class Database
    {
        private readonly string _connectionString;

        public Database()
        {
            _connectionString = "Server=localhost;Database=gestionnaire;Uid=root;Pwd=;";
        }

        public IDbConnection CreateConnection()
        {
            return new MySqlConnection( _connectionString );
        }
    }
}
