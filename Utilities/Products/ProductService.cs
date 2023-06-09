﻿using Microsoft.EntityFrameworkCore;

namespace HeatMaps.Utilities.Products
{
    public class ProductService : IProductService
    {
        public readonly ApplicationDbContext _productsContext;
        public ProductService(ApplicationDbContext productsContext)
        {
            _productsContext = productsContext;
        }
        async Task<Product> IProductService.Get(int id)
        {
            var Product = await _productsContext.Products.FindAsync(id);
            if (Product != null) return Product;
            var result = Enumerable.Empty<Product>().ToList().First();
            return result;
        }

        async Task<Product> IProductService.Get(string ProductId)
        {
            var Product = await _productsContext.Products.FindAsync(ProductId);
            if (Product != null) return Product;
            var result = Enumerable.Empty<Product>().ToList().First();
            return result;
        }

        public async Task<List<Product>> GetAll()
        {
            var Products = await _productsContext.Products.ToListAsync();
            if (Products != null) return Products;
            var result = Enumerable.Empty<Product>().ToList();
            return result;
        }

        async void IProductService.Update(int id, Product newProductDetails)
        {
            var Product = await _productsContext.Products.FindAsync(id);
            if (Product != null)
            {
                Product.Name = newProductDetails.Name;
                Product.Description = newProductDetails.Description;
                var result = _productsContext.Products.Attach(Product);
                result.State = EntityState.Modified;
            }
            await _productsContext.SaveChangesAsync();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Add(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
