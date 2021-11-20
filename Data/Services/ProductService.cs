using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Data.Interfaces;
using WebApplication1.Data.Models;

namespace WebApplication1.Data.Repository
{
    public class ProductService : Service
    {
        private readonly AppDBContent appDBContent;

        public ProductService(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }
        public IEnumerable<Product> Products => appDBContent.Product.Include(c=>c.Person);

        public IEnumerable<Product> GetProductsByPersonId(int id) => appDBContent.Product.Where(p => p.PersonId == id).Include(c => c.Person);

        public Product GetProductsById(int id) => appDBContent.Product.FirstOrDefault(p => p.Id == id);
    }
}
