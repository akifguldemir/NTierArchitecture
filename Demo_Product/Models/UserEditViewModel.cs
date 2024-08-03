using System.ComponentModel.DataAnnotations;

namespace Demo_Product.Models
{
    public class UserEditViewModel
    {

        [Required(ErrorMessage = "Lütfen isim giriniz")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Lütfen soyisim giriniz")]
        public string SurName { get; set; }

        [Required(ErrorMessage = "Lütfen cinsiyet giriniz")]
        public string Gender { get; set; }

        [Required(ErrorMessage = "Lütfen mail giriniz")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Lütfen şifre giriniz")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Lütfen şifre tekrar giriniz")]
        [Compare("Password", ErrorMessage = "Şifre eşleşmiyor")]
        public string ConfirmPassword { get; set; }
    }
}
