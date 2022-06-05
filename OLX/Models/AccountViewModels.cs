namespace OLX.Models
{
   
    public class ForgotPasswordModel
    {
        public string Email { get; set; }
    }

    public class ChangePasswordViewModel
    {
        public string UserId { get; set; }
        public string Token { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
    }
}
