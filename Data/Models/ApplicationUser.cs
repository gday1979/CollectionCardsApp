namespace CollectionCards.Data.Models
{
    using Microsoft.AspNetCore.Identity;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

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
