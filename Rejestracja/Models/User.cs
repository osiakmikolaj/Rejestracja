using System.ComponentModel.DataAnnotations;

namespace Rejestracja.Models
{
    public class User
    {
        [Required(ErrorMessage = "Name is required.")]
        [MinLength(2, ErrorMessage = "The name must have at least 2 characters.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Last name is required.")]
        [MinLength(2, ErrorMessage = "The last name must have at least 2 characters.")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "E-mail address is required.")]
        [EmailAddress(ErrorMessage = "Please enter correct e-mail address.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required.")]
        [DataType(DataType.Password)]
        [MinLength(8, ErrorMessage = "The password must have at least 8 characters.")]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).+$", ErrorMessage = "The password must contain at least one lowercase letter, an uppercase letter and a number.")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Confirmation of the password is required.")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "The passwords must be the same.")]
        public string ConfirmPassoword { get; set; }

        [Phone(ErrorMessage = "Enter the correct phone number.")]
        public string Phone { get; set; }

        [Range(11, 80, ErrorMessage = "The age must be between 11 and 80.")]
        public int Age { get; set; }

        [Required(ErrorMessage = "Select a city.")]
        [Range(1, int.MaxValue, ErrorMessage = "Select a city.")]
        public Cities City { get; set; }
    }
}
