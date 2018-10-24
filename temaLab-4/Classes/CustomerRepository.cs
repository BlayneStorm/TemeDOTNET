using System;
using System.Linq;

namespace Classes
{
    public class CustomerRepository
    {
        private readonly ProductCustomerManagement _context;

        public CustomerRepository()
        {
            _context = new ProductCustomerManagement();
        }

        public void Create(Customer customer)
        {
            _context.Customers.Add(customer);
            _context.SaveChanges();
        }

        public void Update(Customer customer)
        {
            var existingCustomer = this._context.Customers.First(c => c.Id == customer.Id);
            existingCustomer.Address = customer.Address;
            existingCustomer.Email = customer.Email;

            _context.SaveChanges();
        }

        public void Delete(Customer customer)
        {
            var existingCustomer = this._context.Customers.Find(customer.Id);
            _context.Customers.Remove(existingCustomer);
            _context.SaveChanges();
        }

        public Customer GetById(Guid id)
        {
            return this._context.Customers.First(c => c.Id == id);
        }

        public IQueryable<Customer> GetCustomerByEmail(String email)
        {
            IQueryable<Customer> query = _context.Customers
                .Where(customer => customer.Email == email);
            return query;
        }

    }
}