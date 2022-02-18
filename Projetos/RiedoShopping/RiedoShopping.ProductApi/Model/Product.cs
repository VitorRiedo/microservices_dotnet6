﻿using RiedoShopping.ProductApi.Model.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RiedoShopping.ProductApi.Model
{
    [Table("Product")]
    public class Product: BaseEntity
    {
        [Column("Name")]
        [Required]
        [StringLength(150)]
        public string Name { get; set; }

        [Column("Price")]
        [Required]
        [Range(0.01,10000)]
        public decimal Price { get; set; }

        [Column("Description")]
        [StringLength(500)]
        public string Description { get; set; }

        [Column("Category_Name")]
        [StringLength(50)]
        public string Category_Name { get; set; }

        [Column("Image_Url")]
        [StringLength(300)]
        public string Image_Url { get; set; }
    }
}
