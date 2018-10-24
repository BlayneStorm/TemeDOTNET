using System;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace Classes
{
    public class Product
    {
        public Guid Id {get; set;}

        [Required]
        [StringLength(50)]
        public String Name {get;  set;}
        
        public String Description {get;  set;}
        
        [Required]
        public DateTime StartDate {get;  set;}
        
        public DateTime EndDate {get;  set;}
        
        [Required]
        public int Price {get;  set;}

        [Required]
        public int VAT {get;  set;}

        

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
