using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace webapi_2mvc.Models
{
    public class StudentviewModel
    {

        [Key]
        public int id { get; set; }
        [Required]
        [DisplayName("Student name")]
        public string? Ad { get; set; }
        [Required]

        public string? Soyad { get; set; }

        [Required]

        public int? problemSolving { get; set; }

        [Required]

        public int? oop { get; set; }

        [Required]


        public int? cleancode { get; set; }

        [Required]


        public int? algorithm { get; set; }
        [Required]


        public int? teamwork { get; set; }


        public double? Ortalama => (oop + cleancode + teamwork + algorithm + problemSolving) / 5.0;



    }
}
