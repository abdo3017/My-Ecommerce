using InfraStructure.Database;
using InfraStructure.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Services
{
	public class CategoryRepository : GenericRepository<Category>
	{
		public CategoryRepository(MyDbContext _Context) : base(_Context)
		{
		}
	
	}
}
