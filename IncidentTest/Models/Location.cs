using System;
namespace IncidentTest.Models {
    public class Location {

        public int id { get; set;  }
        public string locationName { get; set;  }
        
        public Location(int id, string locationName) {
            this.id = id;
            this.locationName = locationName;
        }
    }
}
