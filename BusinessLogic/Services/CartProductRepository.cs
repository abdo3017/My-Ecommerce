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
    public class CartProductRepository : GenericRepository<CartItem>
    {
        private readonly MyDbContext context;
        public CartProductRepository(MyDbContext _Context) : base(_Context)
        {
            context = _Context;
        }

        public override IEnumerable<CartItem> Find(Expression<Func<CartItem, bool>> predicate)
        {
            return context.CartItems.Where(predicate).Include(c => c.Product);
        }
        public void Delete(Expression<Func<CartItem, bool>> predicate)
        {
            var CartItems = context.CartItems.Where(predicate);
            foreach (var item in CartItems)
            {
                base.Delete(item);
            }
        }
    }
}
