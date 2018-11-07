using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataLayer;
using Microsoft.EntityFrameworkCore;

namespace BusinessLayer
{
    public class Repository : IRepository
    {
        private readonly CityContext _context;

        public Repository(CityContext context)
        {
            _context = context;
        }

        public async Task Create(City city)
        {
            city.Id = Guid.NewGuid();
            _context.Add(city);
            await _context.SaveChangesAsync();
        }

        public async Task Update(City city)
        {
            _context.Update(city);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteConfirm(Guid id)
        {
            var city = _context.Cities.Find(id);
            _context.Cities.Remove(city);
            await _context.SaveChangesAsync();
        }

        public Task<List<City>> GetAllCities()
        {
            return _context.Cities.ToListAsync();
        }

        public Task<City> FirstOrDefault(Guid? id)
        {
            return _context.Cities.FirstOrDefaultAsync(m => m.Id == id);
        }


        public Task<City> FindAsync(Guid? id)
        {
            return _context.Cities.FindAsync(id);
        }

        public bool Exists(Guid id)
        {
            return _context.Cities.Any(e => e.Id == id);
        }

    }
}
