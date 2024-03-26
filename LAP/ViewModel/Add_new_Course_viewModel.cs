using LAP.Models;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace LAP.ViewModel
{
    public class Add_new_Course_viewModel
    {
        public List<Department> departments { get; set; }


        public int ID { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage = "Length Must be less than 50")]
        [MinLength(2, ErrorMessage = "length Must by more than 2")]
        [UniqueName]
        public string Name { get; set; }

        [Required]
        [Range(50, 100, ErrorMessage = "Degree must be between 50 and 100")]
        public int Degree { get; set; }

        [Required]
        [Remote(action: "Check_minDegree", controller: "Course",
            AdditionalFields = "Degree",
            ErrorMessage = "Min Degree must be less than the Course's Degree")]
        public int MinDegree { get; set; }

        [Required]
        [Remote(action: "Check_hours", controller: "Course", ErrorMessage = "Course's Hours Must be 3 or its multiples")]
        public int CrsHours { get; set; }

        public int DepartmentId { get; set; }

    }
}
