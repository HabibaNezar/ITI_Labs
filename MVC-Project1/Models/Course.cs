using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace MVC_Project1.Models
{
    public class Course: IValidatableObject
    {
        [Key]
        public int CrsId { get; set; }

        [Display(Name = "Course Name")]
        [Remote(action: "IsNameUnique", controller: "Course", AdditionalFields = "CrsId", ErrorMessage = "Course name already exists!")]
        public string Name { get; set; }
        public string Description { get; set; }
        public String? Topics {  get; set; }

        [Required]
        [Range(0, 100)]
        public int MinDegree { get; set; }

        [Required]
        [Range(1, 100)]
        public int MaxDegree { get; set; }

        public ICollection<StudentCourse>? StudentCourses { get; set; }
        public ICollection<InstructorCourse>? InstructorCourses { get; set; }

        public IEnumerable<ValidationResult>? Validate(ValidationContext validationContext)
        {
            if (MinDegree >= MaxDegree)
            {
                yield return new ValidationResult(
                    "Minimum degree must be less than maximum degree.",
                    new[] { nameof(MinDegree) }
                );
            }
        }
    }
}
