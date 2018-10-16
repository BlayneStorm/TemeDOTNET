using System;

namespace Classes {

    public abstract class Employee {

        public int Id {get; private set;}
        public String FirstName {get; private set;}
        public String LastName {get; private set;}
        public DateTime StartDate {get; private set;}
        public DateTime EndDate {get; private set;}
        public int Salary { get; private set;}

        protected Employee(int id, String firstName, String lastName, DateTime startDate, DateTime endDate, int salary)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.Salary = salary;
        }

        public void SetStartDate(DateTime dateTime) {
            this.StartDate = dateTime;
        }

        public void SetEndDate(DateTime dateTime) {
            this.EndDate = dateTime;
        }

        public virtual String GetFullName() {
            return this.FirstName + " " + this.LastName;
        }

        public virtual bool IsActive() {
            return this.StartDate <= DateTime.Today && DateTime.Today <= this.EndDate;
        }
        
        public abstract String Salutation();
    }
}