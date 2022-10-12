using BusinessLogic.Utils;
using InfraStructure.Database;
using InfraStructure.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Services
{
    public class ProductRepository : GenericRepository<Product>
    {
        private readonly IImageHandler imageHandler;
        private readonly MyDbContext context;

        public ProductRepository(IImageHandler imageHandler, MyDbContext _Context) : base(_Context)
        {
            this.imageHandler = imageHandler;
            context = _Context;
        }
        public Product AddProduct(Product entity, IFormFile imageFile)
        {
            var path = imageHandler.UploadImage(imageFile, Constants.PRODUCT_PATH);
            entity.Image = path;
            return base.Add(entity);
        }

        public IEnumerable<Product> GetByType(int categoryId, int typeId)
        {
            return context.Products.Where(p => p.CategoryId == categoryId && p.TypeId == typeId)
                .Include(p => p.Sizes).Include(p => p.Colors);
        }
        public override IEnumerable<Product> GetAll()
        {
            return context.Products.Include(p => p.Sizes).Include(p => p.Colors);
        }
        public IEnumerable<Product> GetByCategory(int categoryId)
        {
            return context.Products.Where(p => p.CategoryId == categoryId)
                .Include(p => p.Sizes).Include(p => p.Colors);
        }
    }
}
