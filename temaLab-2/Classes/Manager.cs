using System;

namespace Classes {

    public class Manager : Employee {

        public Manager(int id, String firstName, String lastName, DateTime startDate, DateTime endDate, int salary) : base (id, firstName, lastName, startDate, endDate, salary) {
            
        }

        public override String Salutation() {
            return "Hello Manager"; 
        }
    }
}