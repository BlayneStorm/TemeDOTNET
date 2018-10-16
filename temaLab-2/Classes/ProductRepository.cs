using System;
using System.Collections.Generic;
using System.Linq;

namespace Classes {

    public class ProductRepository {

        private readonly List<Product> ProductList;

        public ProductRepository(params Product[] products) {
            if (products.Length < 3) {
                throw new ArgumentException("You have to pass at least 3 products as parameters");
            }
            ProductList = new List<Product>();
            foreach (Product product in products) {
                ProductList.Add(product);
            }
        }

        public Product GetProductByName(String productName) {
            Product product = this.ProductList.Find(x => x.Name.Equals(productName));
            if (product == null) {
                throw new ArgumentException("No product with the name " + productName);
            }
            return product;
        }

        public List<Product> FindAllProducts() {
            return this.ProductList;
        }

        public void AddProduct(Product product) {
            if (product == null) {
                throw new ArgumentException("Can't pass a null argument");
            }
            this.ProductList.Add(product);
        }

        public Product GetProductByPosition(int index) {
            if (index < 0 || index >= ProductList.Count) {
                throw new ArgumentException("Index is either lower than 0 or bigger than List.Count");
            }
            return ProductList.ElementAt(index);
        }

        public void RemoveProductByName(String productName) {
            Product product = GetProductByName(productName);
            ProductList.Remove(product);
        }
    }
}