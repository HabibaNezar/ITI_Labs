using MVC_Project1.Context;
using System.ComponentModel.DataAnnotations;

namespace MVC_Project1.Models
{
    public class UniqueAttribute : ValidationAttribute
    {
        private readonly DbAppContext db;

        public UniqueAttribute(DbAppContext context)
        {
            this.db = context;
        }
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            string name = value.ToString();
            Student student = db.Students.FirstOrDefault(s => s.Name == name);
            if (student == null)
            {
                //valid
                return ValidationResult.Success;
            }
            else
            {
                return new ValidationResult("Name should be unique");
            }

        }
    }
}
