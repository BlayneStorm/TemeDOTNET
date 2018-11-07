using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DataLayer
{
    public class City
    {
        public Guid Id { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 50)]
        public string Name { get; set; }

        public double Latitude { get; set; }

        public double Longitude { get; set; }

        [Required]
        [StringLength(150)]
        public string Description { get; set; }

        public bool IsCapital { get; set; }

        public ICollection<Poi> Pois { get; private set; }

        public City()
        {
        }

    }
}
