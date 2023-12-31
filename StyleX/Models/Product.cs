﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StyleX.Models
{
    [Table("Product")]
    public class Product
    {
        [Key]
        public int ProductID { get; set; }
        public string ModelUrl { get; set; } = null!; // url model
        public string PosterUrl { get; set; } = null!; // ảnh hiển thị của product;  
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public double Price { get; set; }
        public double Sale { get; set; } // % giảm giá

        public int CategoryID { get; set; }
        public Category Category { get; set; } = null!;


    }
}
