using System;
using MySql.Data.MySqlClient;

namespace IncidentTest.Models {
    public class IncidentContext {
        
        public string ConnectionString { get; set; }

        public IncidentContext(string connectionString) {
            this.ConnectionString = connectionString;
        }

        public MySqlConnection GetConnection() {
            return new MySqlConnection(ConnectionString);
        }


    }
}
