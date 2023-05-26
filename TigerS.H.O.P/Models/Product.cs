using System.ComponentModel.DataAnnotations;

namespace TigerS.H.O.P.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [MaxLength(100)]
        public string Description { get; set; }
        [Required]
        public string Size { get; set; }
        [Required]
        public string Color { get; set; }
        [Required]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }
        [Required]
        public string ProductImage { get; set; }


    }
}
