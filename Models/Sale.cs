﻿using System.ComponentModel.DataAnnotations;

namespace TheHenkAPI.Classes
{
    public class Sale
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public float Price { get; set; }
        [Required]
        public virtual ICollection<Item>? Items { get; set; }
    }
}
