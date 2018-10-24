using System;
using System.ComponentModel.DataAnnotations;

namespace Classes
{
    public class Customer
    {
        public Guid Id {get; set;}

        public string Name {get; set;}

        public string Address {get; set;}

        [RegularExpression(@"^\+40[0-9]{9}$", ErrorMessage="Nu e bun numarul")]
        public string PhoneNumber {get; set;}

        [RegularExpression(@"^[a-z]+(\.[a-z]+)?\@[a-z]+\.com$", ErrorMessage="Email incorect")]
        public string Email {get; set;}
    }
}