using System.ComponentModel.DataAnnotations;

namespace HotelListing.Dtos
{
    public class CreateHotelDTO
    {

        [Required]
        [StringLength(150, ErrorMessage = "Hotel name is too long!")]
        public string Name { get; set; }

        [Required]
        [MaxLength(250, ErrorMessage = "Address is too long!")]
        public string Address { get; set; }

        [Required]
        [Range(1, 5, ErrorMessage = "Rating must be a number betwen 1 and 5.")]
        public double Rating { get; set; }

        [Required]
        public int CountryId { get; set; }

    }
    public class HotelDTO : CreateHotelDTO
    {
        public int HotelId { get; set; }
        public CountryDTO Country { get; set; }

    }

}
