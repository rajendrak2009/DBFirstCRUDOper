using System.ComponentModel.DataAnnotations;

namespace DBFirstCRUDOper.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name ="Product Name")]
        public string? Name { get; set; }
        [Required]
        public string? Description { get; set; }
        public string? Color { get; set; }
        [Required]
        public int Price { get; set; }
        public string? Image { get; set; }
        public int CategoryID { get; set; }
    }
}
