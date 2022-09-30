using InfraStructure.Database;
using InfraStructure.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Services
{
	public class SizeRepository : GenericRepository<Size>
	{
		public SizeRepository(MyDbContext _Context) : base(_Context)
		{
		}
	}
}
