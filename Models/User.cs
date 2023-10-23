﻿using System.ComponentModel.DataAnnotations;

namespace TheHenkAPI.Classes
{
    public class User
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public string? Password { get; set; }
        public virtual ICollection<Order>? Orders { get; set; }

    }
}
