using System.ComponentModel.DataAnnotations;

namespace Demo_Product.Models
{
    public class UserLoginViewModel
    {
        [Required(ErrorMessage = "Kullanıcı adı gir")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Şifre gir")]
        public string Password { get; set; }
    }
}
