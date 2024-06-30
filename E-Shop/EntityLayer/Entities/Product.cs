using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Açıklama")]
        [Required(ErrorMessage = "Boş geçilemez!")]
        [StringLength(50, ErrorMessage = "Maksimum 50 karakter olabilir!")]
        public string Description { get; set; }

        [Display(Name = "Fiyat")]
        [Required(ErrorMessage = "Boş geçilemez!")]
        public decimal Price { get; set; }

        [Display(Name = "Stok")]
        [Required(ErrorMessage = "Boş geçilemez!")]
        public int Stock { get; set; }

        [Display(Name = "Popüler")]
        [Required(ErrorMessage = "Boş geçilemez!")]
        public bool Popular { get; set; }

        [Display(Name = "Onay")]
        [Required(ErrorMessage = "Boş geçilemez!")]
        public bool IsApproved { get; set; }

        [Display(Name = "Resim")]
        [Required(ErrorMessage = "Boş geçilemez!")]
        public string Image { get; set; }

        [Display(Name = "Adet")]
        [Required(ErrorMessage = "Boş geçilemez!")]
        public int Quantity { get; set; }

        public int CategoryId { get; set; }


        public virtual Category Category { get; set; }
    }
}
