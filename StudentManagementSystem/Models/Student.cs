using System.ComponentModel.DataAnnotations;

namespace StudentManagementSystem.Models   // ⭐ REQUIRED ⭐
{
    public class Student
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Range(1, 12, ErrorMessage = "Grade must be between 1 and 12")]
        public int Grade { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [Phone]
        public string Phone { get; set; }
    }
}



