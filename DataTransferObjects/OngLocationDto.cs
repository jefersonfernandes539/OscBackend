using System.ComponentModel.DataAnnotations;

namespace OscBackend.DataTransferObjects
{
    public class OngLocationDto
    {
        public Guid Id { get; set; }
        [Required]
        public string? Name { get; set; } = null;

        public string? Description { get; set; } = null;

        [Required]
        public double Latitude { get; set; }

        [Required]
        public double Longitude { get; set; }

        public string? Address { get; set; } = null;

        public string? Phone { get; set; } = null;

        public string? Email { get; set; } = null;

        public string? Type { get; set; } = null;
        public List<string> Services { get; set; } = [];

    }
}
