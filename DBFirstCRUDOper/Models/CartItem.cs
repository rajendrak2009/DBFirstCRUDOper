using System.ComponentModel.DataAnnotations;

namespace DBFirstCRUDOper.Models
{
    public class CartItem
    {
        [Key]
        public int ItemID { get; set; }
        [Required]
        public string? CardID { get; set; }
        public int Quantity{ get; set; }
        public int ProductID { get; set; }
        public virtual Product Product { get; set; }
    }
}
