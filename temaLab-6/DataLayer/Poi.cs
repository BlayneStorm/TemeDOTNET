using System;
using System.ComponentModel.DataAnnotations;

namespace DataLayer
{
    public class Poi : IPoi
    {

        public Guid Id { get; private set; }

        [Required]
        [StringLength(100, MinimumLength = 50)]
        public string Name { get; private set; }

        [Required]
        [StringLength(150)]
        public string Description { get; private set; }

        public double Latitude { get; set; }

        public double Longitude { get; set; }

        public Guid? CityId { get; set; }

        public virtual City City { get; set; }

        public Poi(string name, string description)
        {
            Id = Guid.NewGuid();
            Name = name;
            Description = description;
        }

    }

}
