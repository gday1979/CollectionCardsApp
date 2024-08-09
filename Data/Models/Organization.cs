﻿namespace CollectionCards.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Organization
    {
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }

        public string? Street { get; set; }

        public string? City { get; set; }

        public string? Country { get; set; }

        public string? PostalCode { get; set; }

        public virtual ICollection<Card> Cards { get; set; }
    }
}
