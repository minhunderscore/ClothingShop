using Microsoft.AspNetCore.Identity;

namespace ClothingShop.Entity.Entities
{
    public class Products : IdentityRole
    {
        public int CategoryId { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(100)]
        public string Discription { get; set; }

        // [Display(Name = "Create Date"), DataType(DataType.Date)]
        // [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime CreateTime { get; set; }

        // [Display(Name = "LastModified Date"), DataType(DataType.Date)]
        // [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime LastModified { get; set; }
    }
}