using System;
using System.Threading.Tasks;
using DataLayer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BusinessLayer;

namespace Lab6.Controllers
{
    public class CitiesController : Controller
    {
        private IRepository _cityRepository;

        public CitiesController(IRepository cityRepo)
        {
            _cityRepository = cityRepo;
        }

        // GET: Cities
        public async Task<IActionResult> Index()
        {
            return View(await _cityRepository.GetAllCities());
        }

        // GET: Cities/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var city = await _cityRepository.FirstOrDefault(id);
            if (city == null)
            {
                return NotFound();
            }

            return View(city);
        }

        // GET: Cities/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Cities/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Latitude,Longitude,Description,IsCapital")] City city)
        {
            if (ModelState.IsValid)
            {
                await _cityRepository.Create(city);
                return RedirectToAction(nameof(Index));
            }
            return View(city);
        }

        // GET: Cities/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var city = await _cityRepository.FindAsync(id);
            if (city == null)
            {
                return NotFound();
            }
            return View(city);
        }

        // POST: Cities/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,Name,Latitude,Longitude,Description,IsCapital")] City city)
        {
            if (id != city.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    await _cityRepository.Update(city);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CityExists(city.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(city);
        }

        // GET: Cities/DeleteConfirm/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var city = await _cityRepository.FirstOrDefault(id);

            if (city == null)
            {
                return NotFound();
            }

            return View(city);
        }

        // POST: Cities/DeleteConfirm/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            await _cityRepository.DeleteConfirm(id);
            return RedirectToAction(nameof(Index));
        }

        private bool CityExists(Guid id)
        {
            return _cityRepository.Exists(id);
        }

    }
}
