using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace Test.Models
{
    [Table("NTN0535s")]
    public class NTN0535
    {
        [Key]
        [StringLength(20)]
        public string NTNId { get; set; }
        [StringLength(50)]
        [Required(ErrorMessage="Yêu cầu nhập NTNName.")]
        [Display(Name = "Tên")]
        public string NTNName { get; set; }
        [Required(ErrorMessage="Yêu cầu nhập NTNGender.")]
        [Display(Name = "Giới Tính")]
        public string NTNGender { get; set; }
    }
    
}
