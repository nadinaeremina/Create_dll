using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Create_dll.Model;
using Microsoft.EntityFrameworkCore;

namespace Create_dll.Repositories
{
    public class RepositoryDB
    {
        public async Task<List<Product>> GetAllProducts()
        {
            var productContext = new ProductContext();
            return await productContext.products.ToListAsync();
        }
        public async Task AddProductAsync(Product product)
        {
            var productContext = new ProductContext();
            await productContext.products.AddAsync(product);
            await productContext.SaveChangesAsync();
        }
        public async Task RemoveProductAsync(Product product)
        {
            var productContext = new ProductContext();
            productContext.products.Remove(product);
            await productContext.SaveChangesAsync();
        }
        public async Task UpdateProductAsync(int id, Product product)
        {
            var productContext = new ProductContext();
            var updatingProducts = await productContext.products.FirstAsync(x => x.Id == id);

            updatingProducts.Title = product.Title;
            updatingProducts.Price = product.Price;
            updatingProducts.Count = product.Count;
            updatingProducts.Description = product.Description;

            await productContext.SaveChangesAsync();
        }
    }
}
