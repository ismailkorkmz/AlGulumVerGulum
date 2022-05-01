using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AldimGulumVerdimGulum.Models
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage ="Kullanıcı Adı Boş Geçilemez")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Mail Boş Geçilemez")]
        [EmailAddress(ErrorMessage ="Geçerli Bir Adres Gir")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required(ErrorMessage ="Şifre Boş Geçilemez")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required(ErrorMessage = "Şifre Tekrar Zorunlu Alan")]
        [DataType(DataType.Password)]
        [Compare("Password")]
        
        public string PasswordConfir { get; set; }
    }
}
