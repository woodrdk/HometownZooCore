using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HometownZooCore.Models
{
    public class Animal
    {
        [Key]
        public int AnimalId { get; set; }

        [Required]
        [StringLength(30)]
        public string Name { get; set; }

        [Required]
        public string Breed { get; set; }

        [Display(Name = "Adoption Date")]
        public DateTime? AdoptionDate { get; set; }
    }
}
