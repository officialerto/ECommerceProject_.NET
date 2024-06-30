using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Ad")]
        [Required(ErrorMessage = "Boş geçilemez!")]
        [StringLength(50, ErrorMessage = "Maksimum 50 karakter olabilir!")]
        public string Name { get; set; }

        [Display(Name = "Soyad")]
        [Required(ErrorMessage = "Boş geçilemez!")]
        [StringLength(50, ErrorMessage = "Maksimum 50 karakter olabilir!")]
        public string SurName { get; set; }

        [Display(Name = "Açıklama")]
        [Required(ErrorMessage = "Boş geçilemez!")]
        [StringLength(50, ErrorMessage = "Maksimum 50 karakter olabilir!")]
        [EmailAddress(ErrorMessage = "Geçersiz format!")]
        public string Email { get; set; }

        [Display(Name = "Kullanıcı Adı")]
        [Required(ErrorMessage = "Boş geçilemez!")]
        [StringLength(50, ErrorMessage = "Maksimum 50 karakter olabilir!")]
        public string UserName { get; set; }

        [Display(Name = "Şifre")]
        [Required(ErrorMessage = "Boş geçilemez!")]
        [StringLength(15, ErrorMessage = "Maksimum 15 karakter olabilir!")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Tekrar Şifre")]
        [Required(ErrorMessage = "Boş geçilemez!")]
        [StringLength(15, ErrorMessage = "Maksimum 15 karakter olabilir!")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Şifreler uyuşmuyor!")]
        public string RePassword { get; set; }

        [StringLength(10, ErrorMessage = "Maksimum 10 karakter olabilir!")]
        public string Role { get; set; }
    }
}
