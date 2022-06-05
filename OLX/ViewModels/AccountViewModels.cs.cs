using System.ComponentModel.DataAnnotations;


namespace OLX.ViewModels
{
    public class LoginViewModel
    {
        [EmailAddress(ErrorMessage = "Має бути пошта!")]
        [Required(ErrorMessage = "Поле не може бути пустим!")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Поле не може бути пустим!")]
        public string Password { get; set; }
    }
    public class RegisterViewModel
    {
        [EmailAddress(ErrorMessage = "Має бути пошта!")]
        [Required(ErrorMessage = "Поле не може бути пустим!")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Поле не може бути пустим!")]
        [RegularExpression(@"^(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?!.*\s).{6,24}$", ErrorMessage = "Password must be at least 6 characters and contain digits, upper and lower case")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Поле не може бути пустим!")]
        public string PasswordConfirm { get; set; }
    }
    public class UserItemViewModel
    {
        public long Id { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
    }

    public class ConfirmEmailViewModel
    {
        [Required(ErrorMessage = "Cant't be empty")]
        public string Code { get; set; }
    }
}