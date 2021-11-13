using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClothingShop.Entity.Entities
{
    public class Products
    {
        [Required]
        public int ProductId { get; set; }

        [StringLength(50), Required]
        public string Name { get; set; }

        [Required]
        public int Image { get; set; }

        [Required, DataType(DataType.Currency)]
        public int Price { get; set; }

        [Range(1, 100)]
        [Column(TypeName = "decimal(4, 2)")]
        public decimal? Discount { get; set; }

        [StringLength(500)]
        #nullable enable
        public string? Discription { get; set; }
        #nullable disable

        [Required]
        [Display(Name = "Create Date"), DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime CreateTime { get; set; }

        [Required]
        [Display(Name = "LastModified Date"), DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime LastModified { get; set; }
    }
}