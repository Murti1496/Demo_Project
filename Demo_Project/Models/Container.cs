using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Demo_Project.Models
{
    public class Container
    {
        [Key]
        public int ContainerID { get; set; }

        [Required]
        public string ContainerNumber { get; set; }

        [Required]
       
        public DateTime ShipmentDate { get; set; }

        [Required]
        public string OriginPort { get; set; }

        [Required]
        public string DestinationPort { get; set; }

        [Required]
        public string Status { get; set; }

        [Required]
        public string FilePath { get; set; }

        [NotMapped] // Ensures this property is not added to the database
        public IFormFile UploadedFile { get; set; }
    }
}
