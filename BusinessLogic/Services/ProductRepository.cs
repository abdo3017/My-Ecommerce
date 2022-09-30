using BusinessLogic.Utils;
using InfraStructure.Database;
using InfraStructure.Entity;
using Microsoft.AspNetCore.Http;
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

		public ProductRepository(IImageHandler imageHandler, MyDbContext _Context) : base(_Context)
		{
			this.imageHandler = imageHandler;
		}
        public void AddProduct(Product entity, IFormFile imageFile)
        {
            var path = imageHandler.UploadImage(imageFile);
			Console.WriteLine(path);
			entity.Image = path;
			base.Add(entity);
        }
    }
}
