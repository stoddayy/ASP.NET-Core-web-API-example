﻿using System;
namespace IncidentTest.Models {
    public class User {

        public int id { get; set; }
        public string name { get; set; }

        public User(int id, string name) {
            this.id = id;
            this.name = name;
        }

        public User(){
            
        }
    }
}
