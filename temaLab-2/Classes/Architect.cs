using System;

namespace Classes {

    public class Architect : Employee {

        public Architect(int id, String firstName, String lastName, DateTime startDate, DateTime endDate, int salary) : base (id, firstName, lastName, startDate, endDate, salary) {
            
        }

        public override String Salutation() {
            return "Hello Architect"; 
        }
    }
}