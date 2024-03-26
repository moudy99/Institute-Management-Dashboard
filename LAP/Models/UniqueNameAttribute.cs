using System.ComponentModel.DataAnnotations;

namespace LAP.Models
{
    public class UniqueNameAttribute : ValidationAttribute
    {
        Context context = new Context();


        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            Course? crs = validationContext.ObjectInstance as Course;

            if (value != null)
            {

                string Course_name = value.ToString();

                Course course = context.Course.FirstOrDefault(c => c.Name == Course_name);
                if (crs.ID != 0)
                {
                    String crName = context.Course.FirstOrDefault(c => c.ID == crs.ID).Name;

                    if (crName == Course_name)
                    {
                        return ValidationResult.Success;
                    }
                }

                if (course == null)
                {

                    return ValidationResult.Success;
                }
                else
                    return new ValidationResult("Name Must be Unique");
            }


            return ValidationResult.Success;

        }
    }
}
