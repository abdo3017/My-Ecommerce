using InfraStructure.Entity;

namespace ECommerce.ViewModel
{
    public class FavouriteProductViewModel
    {
        public int IdProduct { get; set; }
        public string IdUser { get; set; }
        public Product Product { get; set; }
    }
}
