﻿using System.ComponentModel.DataAnnotations;

namespace BaseProject.Models.Dto
{
    public class VillaUpdateDto
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        public string Name { get; set; }
        public string Detail{ get; set; }

        
        public double Price { get; set; }

        [Required]
        public int Occupants { get; set; }

        [Required]
        public int SquareMeters { get; set; }
        [Required]
        public string ImgUrl { get; set; }
        public string Amenity { get; set; }

    }
}
