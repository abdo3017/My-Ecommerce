using InfraStructure.Database;
using InfraStructure.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Services
{
	public class CategoryRepository : GenericRepository<Category>
	{
        private readonly MyDbContext context;

        public CategoryRepository(MyDbContext _Context) : base(_Context)
		{
            context = _Context;
        }
		public override IEnumerable<Category> GetAll()
		{
			return context.Categorys.Include(c => c.Products).Include(x=>x.Types).ToList();
		}
        public override Category GetById(int id)
        {
            return context.Categorys.Where(c => c.Id == id).Include(c => c.Products).Include(x => x.Types).FirstOrDefault();
        }
    }
}
