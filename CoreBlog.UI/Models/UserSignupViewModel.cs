using System.ComponentModel.DataAnnotations;

namespace CoreBlog.UI.Models
{
    public class UserSignupViewModel
    {
        [Display(Name="Ad Soyad")]
        [Required(ErrorMessage ="Ad soyad alanı boş bırakılamaz.")]
        public string NameSurname { get; set; }

        [Display(Name = "Şifre")]
        [Required(ErrorMessage = "Şifre alanı boş bırakılamaz.")]
        public string Password { get; set; }


        [Display(Name = "Şifre Tekrarı")]
        [Compare("Password", ErrorMessage ="Şifreler Uyuşmuyor!")]
        public string ConfirmPassword { get; set; }


        [Display(Name = "Mail Adresi")]
        [Required(ErrorMessage = "Mail alanı boş bırakılamaz.")]
        public string Mail { get; set; }

        [Display(Name = "Kullanıcı Adı")]
        [Required(ErrorMessage = "Kullanıcı adı alanı boş bırakılamaz.")]
        public string Username { get; set; }

    }
}
