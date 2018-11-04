using System;
using Classes;

namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var unitOfWork = new UnitOfWork(new ApplicationContext());
           // unitOfWork.CityRepo.Add(new City() {Id = Guid.NewGuid(), Name = "Iasi", Description = "Oras frumos", Latitude = 20.0f, Longitude = 50.0f});
            
            unitOfWork.PoiRepo.Add(new Poi() {Id = Guid.NewGuid(), Name = "Palatul Culturii", Description = "O cladire mare si frumoasa"});
            
            unitOfWork.Save();
        }
    }
}
