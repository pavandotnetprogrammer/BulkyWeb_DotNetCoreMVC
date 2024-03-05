using MyBulky.DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBulky.DataAccess.Repository.IRepository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext dbContext;
        public ICategoryRepository Category { get; private set; }
        public IProductRepository Product { get; private set; }

        public UnitOfWork(ApplicationDbContext dbContext) 
        {
            this.dbContext = dbContext;
            Category = new CategoryRepository(this.dbContext);
            Product = new ProductRepository(this.dbContext);

        }
        

        public void Save()
        {
            dbContext.SaveChanges();
        }
    }
}
