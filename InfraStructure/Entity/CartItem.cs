﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace InfraStructure.Entity
{
    public class CartItem
    {
        public int Id { get; set; }
        public int Quantity { get; set; }

        public int IdProduct { get; set; }
        public Product Product { get; set; }

        public string IdUser { get; set; }
        public User User { get; set; }
    }
}
