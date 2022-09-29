using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ECommerce.ViewModel
{
    public class ProductViewModel
    {
        [Required, MaxLength(100)]
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        [Display(Name = "Upload Image")]
        public ICollection<IFormFile> ImageFile { get; set; }
        public ICollection<string> Colors { get; set; }
        public ICollection<string> Sizes { get; set; }

        public int IdBrand { get; set; }
        public int IdType { get; set; }
        public int IdCategory { get; set; }
    }
}
