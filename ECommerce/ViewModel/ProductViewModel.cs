using AutoMapper.Configuration.Annotations;
using Domain.Models;
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
        public string Brand { get; set; }
        public int TypeId { get; set; }
        public int CategoryId { get; set; }
        public string Image { get; set; }
		[Required]
        public ICollection<Color> Colors { get; set; }
		[Required]
        public ICollection<Size> Sizes{ get; set; }
        [Required,Display(Name = "Upload Image")]
        public IFormFile File { get; set; }
    }
}
