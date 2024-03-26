using System.ComponentModel.DataAnnotations;

namespace LAP.ViewModel
{
    public class Login_viewModel
    {
        public string UserName { get; set; }

        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        public string Role { get; set; } // Trainee, Instructor, Admin

        public bool RememberMe { get; set; }

    }
}
