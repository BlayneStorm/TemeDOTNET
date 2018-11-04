using System;
using System.Linq;

namespace Classes
{
    public class CityRepository
    {
        private readonly ApplicationContext _context;

        public CityRepository(ApplicationContext context)
        {
            _context = context;
        }

        public void Add(City city)
        {
            _context.Cities.Add(city);
            _context.SaveChanges();
        }

        public void Delete(Guid guid)
        {
            var existingCity = _context.Cities.First(c => c.Id == guid);
            _context.Cities.Remove(existingCity);
            _context.SaveChanges();
        }
    }
}