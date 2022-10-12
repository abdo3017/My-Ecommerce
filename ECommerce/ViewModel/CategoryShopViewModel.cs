using InfraStructure.Entity;
using System.Collections.Generic;

namespace ECommerce.ViewModel
{
    public class CategoryShopViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<Type> Types { get; set; }
    }
}
