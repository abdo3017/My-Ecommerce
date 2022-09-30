﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfraStructure.Entity
{
    public class Type
    {
        public int Id { get; set; }
        [Required, MaxLength(50)]
        public string Name { get; set; }
		//[ForeignKey("Category")]
		public int? CategoryId { get; set; }
		public Category Category { get; set; }
		public ICollection<Product> Products { get; set; }
       
    }
}
