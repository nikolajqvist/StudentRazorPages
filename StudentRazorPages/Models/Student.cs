using System.ComponentModel.DataAnnotations;

namespace StudentRazorPages.Models
{
    public class Student
    {
        [Range(1, 200)]
        public int Id { get; set; }
        [Required, MaxLength(30)]
        public string Name { get; set; }

        [Required]
        public string ImagePath { get; set; }
        [Required]
        public Section Section { get; set; }
    }
}
