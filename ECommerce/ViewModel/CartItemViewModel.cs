using InfraStructure.Entity;

namespace ECommerce.ViewModel
{
	public class CartItemViewModel
	{
		public int Quantity { get; set; }
		public int ProductId { get; set; }
		public Product Product { get; set; }
		public string UserId { get; set; }
	}
}
