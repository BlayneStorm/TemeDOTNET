using System;
using System.Linq;

namespace Classes
{
    public class PoiRepository
    {
        private readonly ApplicationContext _context;

        public PoiRepository(ApplicationContext context)
        {
            _context = context;
        }

        public void Add(Poi poi)
        {
            _context.Pois.Add(poi);
            _context.SaveChanges();
        }

        public void Delete(Guid guid)
        {
            var existingPoi = _context.Pois.First(p => p.Id == guid);
            _context.Pois.Remove(existingPoi);
            _context.SaveChanges();
        }
    }
}