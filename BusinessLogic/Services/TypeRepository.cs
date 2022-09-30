using InfraStructure.Database;
using InfraStructure.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Services
{
	public class TypeRepository : GenericRepository<Type>
	{
		public TypeRepository(MyDbContext _Context) : base(_Context)
		{
		}
	}
}
