﻿using System.ComponentModel.DataAnnotations;

namespace CaliTrack.Models
{
    public class ExerciseCategory
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        public int DisplayOrder { get; set; }
    }
}
