using MyBulky.DataAccess.Data;
using MyBulky.DataAccess.Repository.IRepository;
using MyBulky.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBulky.DataAccess.Repository
{
    public class ProductRepository:Repository<Product>,IProductRepository
    {
        private readonly ApplicationDbContext dbContext;

        public ProductRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
            this.dbContext = dbContext;
        }

        public void Update(Product objProduct)
        {
            //dbContext.Products.Update(objProduct);
            var objFromDb = dbContext.Products.FirstOrDefault(u => u.Id == objProduct.Id);
            if (objFromDb != null)
            {
                objFromDb.Title = objProduct.Title;
                objFromDb.ISBN = objProduct.ISBN;
                objFromDb.Price = objProduct.Price;
                objFromDb.Price50 = objProduct.Price50;
                objFromDb.ListPrice = objProduct.ListPrice;
                objFromDb.Price100 = objProduct.Price100;
                objFromDb.Description = objProduct.Description;
                objFromDb.CategoryId = objProduct.CategoryId;
                objFromDb.Author = objProduct.Author;
                //objFromDb.ProductImages = obj.ProductImages;
                if (objProduct.ImageURL != null)
                {
                    objFromDb.ImageURL = objProduct.ImageURL;
                }
            }
        }
    }
}
