using System;
using Classes;

namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var repository = new CustomerRepository();

            var entity = new Customer
            {
                Id =  Guid.NewGuid(),
                Name = "John",
                Address = "Octav Bancila",
                PhoneNumber = "+40746523440",
                Email = "mihnea.bigu@yahoo.com"
            };

            repository.Create(customer: entity);
            entity.Address = "Pacurari";
            repository.Update(entity);
        }
    }
}
