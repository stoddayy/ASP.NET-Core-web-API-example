using System;
using System.Collections.Generic;
using IncidentTest.Models;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;

namespace IncidentTest.Controllers {


    [Route("api/[controller]")]
    public class UserController : Controller{

        private static MySqlConnection connection;
        private readonly string connectionString = "Server=localhost;User ID=root;Password=password;Database=incidentTest;Port=3306;Pooling=false";

        public UserController() {
            connection = new MySqlConnection(connectionString);
        }

        [HttpGet]
        public IEnumerable<User> GetAll() {
            List<User> list = new List<User>();

            using (connection) {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand("select * from users", connection);

                using (var reader = cmd.ExecuteReader()) {
                    while (reader.Read()) {
                        list.Add(new User() {
                            id = Convert.ToInt32(reader["id"]),
                            name = reader["name"].ToString()
                        });
                    }
                }
            }
            return list;
        }
    }
}
