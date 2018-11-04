using System;
using System.ComponentModel.DataAnnotations;

namespace Classes
{
    public class Poi
    {
        public Guid Id {get; set;}

        [Required]
        [StringLength(100)]
        public String Name {get; set;}
        
        [Required]
        [StringLength(150)]
        public String Description {get; set;}
        
    }
}
