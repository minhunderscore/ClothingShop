﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ClothingShop.Entity.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name_Product { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateCreated_Product { get; set; }
        public string Type_Product { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price_Product { get; set; }
    }
}
