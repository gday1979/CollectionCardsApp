﻿namespace CollectionCards.Data.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Card
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? ImageUrl { get; set; }
        [Required]
        [Display(Name = "Price")]
        [Range(1, 100000000 , ErrorMessage = "Price must be between 1-10000000")]
        public double Price { get; set; }
        public int YearCard { get; set; }

        public int CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public Category? Category { get; set; }

    }
}
