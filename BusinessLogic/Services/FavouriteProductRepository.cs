using InfraStructure.Database;
using InfraStructure.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Services
{
	public class FavouriteProductRepository : GenericRepository<FavouriteProduct>
    {
        private readonly MyDbContext context;
        public FavouriteProductRepository(MyDbContext _Context) : base(_Context)
        {
            context = _Context;
        }
    }
}
