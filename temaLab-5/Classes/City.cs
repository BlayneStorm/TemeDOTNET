using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Classes
{
    public class City
    {
        public Guid Id {get; set;}

        [Required]
        [StringLength(100)]
        public String Name {get; set;}
        
        [Required]
        [StringLength(150)]
        public String Description {get; set;}
        
        public float Latitude {get; set;}
        
        public float Longitude {get; set;}

        public virtual ICollection<Poi> Pois {get; set;}
    }
}
