using System.ComponentModel.DataAnnotations;

namespace BaseProject.Models.Dto
{
    public class NumberVillaUpdateDto
    {
        [Required]
        public int VillaNo { get; set; }

        [Required]
        public int VillaId { get; set; }
        public string SpecialDetail { get; set; }
    }
}
