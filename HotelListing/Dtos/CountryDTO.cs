using HotelListing.Data;
using System.ComponentModel.DataAnnotations;

namespace HotelListing.Dtos
{
    public class CreateCountryDTO
    {

        [Required]
        [StringLength(50, ErrorMessage = "Country name is too long!")]
        public string Name { get; set; }

        [Required]
        [StringLength(3, ErrorMessage = "Short country name is too long!")]
        public string ShortName { get; set; }
    }
    public class CountryDTO : CreateCountryDTO
    {
        public int CountryId { get; set; }
        public IList<HotelDTO> Hotels { get; set; }

    }

    public class UpdateCountryDTO : CreateCountryDTO
    {

    }

}
