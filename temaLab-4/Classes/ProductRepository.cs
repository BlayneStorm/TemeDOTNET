using System;
using System.Linq;

namespace Classes
{
    public class ProductRepository
    {
        private readonly ProductCustomerManagement _context;

        public ProductRepository()
        {
            _context = new ProductCustomerManagement();
        }

        public void Create(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
        }

        public void Delete(Product product)
        {
            var existingProduct = this._context.Products.Find(product.Id);
            _context.Products.Remove(existingProduct);
            _context.SaveChanges();
        }

        public Product GetById(Guid id)
        {
            return this._context.Products.First(p => p.Id == id);
        }

        public IQueryable<Product> GetProductsByPrice(int price)
        {
            IQueryable<Product> query = _context.Products
                .Where(product => product.Price == price);
            return query;
        }
    }
}