using System.ComponentModel.DataAnnotations;

namespace BaseProject.Models.Dto
{
    public class VillaDto
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        public string Name { get; set; }
        public string Detail{ get; set; }

        
        public double Price { get; set; }

        public int Occupants { get; set; }
       
        public int SquareMeters { get; set; }
        public string ImgUrl { get; set; }
        public string Amenity { get; set; }

    }
}
