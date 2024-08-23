using System.ComponentModel.DataAnnotations;

namespace car_operations.Models
{
    public class OperationCarDto
    {
        [Required]
        public string CarNumber { get; set; }

        [Required]
        public DateTime OperationDate { get; set; }

        [Required]
        public double? Quantity { get; set; }

    }
}
