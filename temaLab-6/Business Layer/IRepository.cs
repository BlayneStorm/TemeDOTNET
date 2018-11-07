using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLayer
{
    public interface IRepository
    {
        Task Create(City city);
        Task Update(City city);
        Task DeleteConfirm(Guid id);
        Task<List<City>> GetAllCities();
        Task<City> FirstOrDefault(Guid? id);
        Task<City> FindAsync(Guid? id);
        bool Exists(Guid id);
    }
}