using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace MagicMushroom.Models
{
    public class Character 
    {
        [Required]
        public string CharacterName { get; set; }
        [Required]
        public string CharacterGender{ get; set; }
        [Required]
        public string CharacterMushroom{ get; set; }
    }
}
