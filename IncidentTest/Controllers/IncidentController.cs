using System;
using System.Collections.Generic;
using IncidentTest.Models;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;

namespace IncidentTest.Controllers {

    [Route("api/[controller]")]
    public class IncidentController : Controller {

        private readonly IncidentContext context;
        private static MySqlConnection connection;
        private readonly string connectionString = "Server=localhost;User ID=root;Password=password;Database=incidentTest;Port=3306;Pooling=false";


        public IncidentController(IncidentContext context) {
            this.context = context;
            connection = new MySqlConnection(connectionString);
        }

        [HttpGet]
        public IEnumerable<IncidentReport> GetAll() {
            List<IncidentReport> list = new List<IncidentReport>();

            using (connection) {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand("select * from reports", connection);

                using (var reader = cmd.ExecuteReader()) {
                    while (reader.Read()) {
                        list.Add(new IncidentReport() {
                            id = Convert.ToInt32(reader["id"]),
                            title = reader["title"].ToString(),
                            description = reader["description"].ToString(),
                            reportedBy = Convert.ToInt32(reader["reportedBy"]),
                            personAffected = Convert.ToInt32(reader["personAffected"]),
                            location = Convert.ToInt32(reader["location"])
                        });
                    }
                }
            }
            return list;
        }

        [HttpGet("{id}", Name = "GetById")]
        public IActionResult GetById(long id) {

            IncidentReport result = null;

            using (connection) {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand("select * from reports where id=" + id, connection);

                using (var reader = cmd.ExecuteReader()) {
                    while (reader.Read()) {
                        result = new IncidentReport() {
                            id = Convert.ToInt32(reader["id"]),
                            title = reader["title"].ToString(),
                            description = reader["description"].ToString(),
                            reportedBy = Convert.ToInt32(reader["reportedBy"]),
                            personAffected = Convert.ToInt32(reader["personAffected"]),
                            location = Convert.ToInt32(reader["location"])

                        };
                    }
                }
            }

            if(result == null){
                return NotFound();
            }
            return new ObjectResult(result);
        }

    }

}

    
