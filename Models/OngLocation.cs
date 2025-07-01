using System.ComponentModel.DataAnnotations;

namespace OscBackend.Models
{
    public class OngLocation : BaseModel
    {
        [Required]
        public string Name { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        [Required]
        public double Latitude { get; set; }

        [Required]
        public double Longitude { get; set; }

        public string Address { get; set; } = string.Empty;

        public string Phone { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public string Type { get; set; } = string.Empty;
        public List<string> Services { get; set; } = [];

    }
}
