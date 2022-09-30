using AutoMapper.Configuration.Annotations;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerce.ViewModel
{
    public class ProductViewModel
    {
        [Required, MaxLength(100)]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public double Price { get; set; }
        [Required]
        public int Quantity { get; set; }
		[Required]
        public ICollection<string> Colors { get; set; }
		[Required]
        public ICollection<string> Sizes { get; set; }

        public string Brand { get; set; }
        public int IdType { get; set; }
        public int IdCategory { get; set; }
		[Ignore]
        [Required,Display(Name = "Upload Image")]
        public IFormFile File { get; set; }
    }
}
