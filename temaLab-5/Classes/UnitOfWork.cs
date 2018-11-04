namespace Classes
{
    public class UnitOfWork
    {
        private CityRepository _cityRepo;
        private PoiRepository _poiRepo;
        private ApplicationContext _context;

        public UnitOfWork(ApplicationContext applicationContext)
        {
            _context = applicationContext;
        }

        public CityRepository CityRepo
        {
            get
            {
                if (_cityRepo == null)
                {
                    _cityRepo = new CityRepository(_context);
                }
                return _cityRepo;
            }
        }

        public PoiRepository PoiRepo
        {
            get
            {
                if (_poiRepo == null)
                {
                    _poiRepo = new PoiRepository(_context);
                }
                return _poiRepo;
            }
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}