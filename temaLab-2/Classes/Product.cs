using System;

namespace Classes{
    public class Product {

        public int Id {get; private set;}
        public String Name {get; private set;}
        public String Description {get; private set;}
        public DateTime StartDate {get; private set;}
        public DateTime EndDate {get; private set;}
        public int Price {get; private set;}
        public int VAT {get; private set;}

        public Product(int id, String name, String description, DateTime startDate, DateTime endDate, int price, int vat) {
            this.Id = id;
            this.Name = name;
            this.Description = description;
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.Price = price;
            this.VAT = vat;
        }

        public bool IsValid() {
            return this.StartDate <= DateTime.Today && DateTime.Today <= this.EndDate;
        }

        public int ComputeVAT() {
            if (this.Price < 0 || this.VAT < 0) {
                throw new ArgumentException("Price or VAT can't be negative values");
            }
            return this.Price + this.VAT * this.Price / 100;
        }
    }
}
