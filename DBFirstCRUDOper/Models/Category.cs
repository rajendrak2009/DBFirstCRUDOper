﻿using System.ComponentModel.DataAnnotations;

namespace DBFirstCRUDOper.Models
{
    public class Category
    {
        [Key] public int CategoryId { get; set; }
        [Required]
        [Display(Name = "Category Name")]
        public string? CategoryName { get; set; }
    }
}
