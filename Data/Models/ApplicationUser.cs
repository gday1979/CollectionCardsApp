﻿namespace CollectionCards.Data.Models
{
    using Microsoft.AspNetCore.Identity;
    using System.ComponentModel.DataAnnotations;

    public class ApplicationUser : IdentityUser
    {
        [Required]
        public string? Name { get; set; }

        public string? Address { get; set; }

        public string? City { get; set; }

        public int? CategoryId { get; set; }

        public Category? Category { get; set; }


        public string? Role { get; set; }
    }
}
