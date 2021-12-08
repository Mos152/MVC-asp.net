using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace contactosProyecto.Models.ViewModels
{
    public class ContactFormModel
    {
        public int Id { get;set; }
        [Required]
        [StringLength(20)]
        [Display(Name = "Name")]
        public string Name { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name = "Number")]
        public string Number { get; set; }
        [Required]
        [Display(Name = "Favorite")]
        public bool Favorite { get; set; }
        [Required]
        [Display(Name = "Emergency")]
        public bool Emergency { get; set; }


    }
}