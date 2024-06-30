using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Display(Name="Ad")]
        [Required(ErrorMessage = "Boş geçilemez!")]
        [StringLength(50, ErrorMessage = "Maksimum 50 karakter olabilir!")]
        public string Name { get; set; }

        [Display(Name = "Açıklama")]
        [Required(ErrorMessage = "Boş geçilemez!")]
        [StringLength(50, ErrorMessage = "Maksimum 50 karakter olabilir!")]
        public string Description { get; set; }

        
        public virtual List<Product> Products { get; set; }

    }
}
