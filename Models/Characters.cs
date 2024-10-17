﻿using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace MagicMushroom.Models
{
    public class Characters 
    {
        [Key]
        [Required]
        public string Name { get; set; }
        [Required]
        public string Gender{ get; set; }
        [Required]
        public string Mushroom {  get; set; }
        
    }
    
}