using InfraStructure.Database;
using InfraStructure.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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
        public override IEnumerable<FavouriteProduct> Find(Expression<Func<FavouriteProduct, bool>> predicate)
        {
            return context.FavouriteProducts.Where(predicate).Include(c => c.Product);
        }
        public void Delete(Expression<Func<FavouriteProduct, bool>> predicate)
        {
            var CartItems = context.FavouriteProducts.Where(predicate);
            foreach (var item in CartItems)
            {
                base.Delete(item);
            }
        }
    }
}
