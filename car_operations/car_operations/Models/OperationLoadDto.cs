using System.ComponentModel.DataAnnotations;

namespace car_operations.Models
{
    public class OperationLoadDto
    {
        [Required]
        public string CarNumber { get; set; }

        [Required]
        public string Load { get; set; }

        [Required]
        public double? Quantity { get; set; }

        [Required]
        public DateTime OperationDate { get; set; }

    }
}
