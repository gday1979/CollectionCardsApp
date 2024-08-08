namespace CollectionCards.Data.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        [Display(Name = "Category Name")]
        public string? Name { get; set; }

        [Display(Name = "Display Order")]
        [Range(1,50,ErrorMessage ="Display Oredr must be between 1-50")]
        public int DisplayOrder { get; set; }


    }
}
