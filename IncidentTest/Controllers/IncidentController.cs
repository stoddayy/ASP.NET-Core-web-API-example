using System;
using System.Collections.Generic;
using IncidentTest.Models;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;

namespace IncidentTest.Controllers {

    [Route("api/[controller]")]
    public class IncidentController : Controller {

        private readonly IncidentContext context;


        public IncidentController(IncidentContext context) {
            this.context = context;
        }


        [HttpGet]
        public IEnumerable<IncidentReport> GetAll() {
            List<IncidentReport> list = new List<IncidentReport>();

            using (MySqlConnection conn = context.GetConnection()) {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("select * from reports", conn);

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





    }

}
