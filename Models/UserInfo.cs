using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MeetingApp.Models
{
    public class UserInfo
    {
        [Required(ErrorMessage = "Ad Soyad alanı zorunlu")]
        public string? Name { get; set; }
        [Required(ErrorMessage = "Telefon alanı zorunlu")]
        public string? Phone { get; set; }
        [Required(ErrorMessage = "Email alanı zorunlu")]
        [EmailAddress(ErrorMessage = "Email adresinizi doğru giriniz")]
        public string? Email { get; set; }
        [Required(ErrorMessage = "Katılım Durumu alanı zorunlu")]
        public bool WillAttend { get; set; }
    }
}