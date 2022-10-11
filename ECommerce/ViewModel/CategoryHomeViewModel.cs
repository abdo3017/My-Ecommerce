using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.ViewModel
{
    public class CategoryHomeViewModel
    {
        public int Id { get; set; }
        [Required, MaxLength(50)]
        public string Name { get; set; }
		[Required]        
        public string Description { get; set; }
		[Required]
		public string Image { get; set; }
		public int ItemCount { get; set; }
    }
}
