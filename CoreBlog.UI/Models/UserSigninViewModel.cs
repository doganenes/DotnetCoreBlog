using System.ComponentModel.DataAnnotations;

namespace CoreBlog.UI.Models
{
    public class UserSigninViewModel
    {
        [Required(ErrorMessage ="Lütfen kullanıcı adı girin!")]
        public String username { get; set; }
        
        [Required(ErrorMessage = "Lütfen şifrenizi girin!")]
        public String password { get; set; }
    }
}