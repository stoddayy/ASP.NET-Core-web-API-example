using System;
namespace IncidentTest.Models {
    public class IncidentReport {

        public int id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public int reportedBy { get; set; }
        public int  personAffected { get; set; }
        public int location { get; set; }

        public IncidentReport(int id, string title, string description, int reportedBy, int personAffected, int location) {
            this.id = id;
            this.title = title;
            this.description = description;
            this.reportedBy = reportedBy;
            this.personAffected = personAffected;
            this.location = location;
        }

        public IncidentReport() {
        }
    }
}
