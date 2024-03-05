using MyBulky.DataAccess.Data;
using MyBulky.DataAccess.Repository.IRepository;
using MyBulky.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MyBulky.DataAccess.Repository
{
    public class CategoryRepository :Repository<Category>, ICategoryRepository
    {
        private readonly ApplicationDbContext dbContext;

        public CategoryRepository(ApplicationDbContext dbContext):base(dbContext)
        {
            this.dbContext = dbContext;
        }       

        public void Update(Category objCategory)
        {
            dbContext.Categories.Update(objCategory);
        }
    }
}
