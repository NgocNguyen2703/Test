using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace Test.Models
{	
[Table("PersonNTN535s")]

    public class PersonNTN535
    {
        [Key]
        [StringLength(20)]
        public string PersonId { get; set; }
        [StringLength(50)]
        [Display(Name = "Tên")]
        public string PersonName { get; set; }
    }
}