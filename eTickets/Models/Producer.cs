using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using eTickets.Data.Base;

namespace eTickets.Models
{
    public class Producer:IEntityBase
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Profile Picture")]
        [Required(ErrorMessage ="Profile Picture is required")] 
        public string ProfilePictureURL { get; set; }

        [Display(Name = "Full Name")]
        [Required(ErrorMessage ="Full name is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Full name must be in between 3 and 50 chars")]

        public string FullName { get; set; }

        [Display(Name = "Biography")]
        [Required(ErrorMessage ="Bio is required")]

        public string Bio { get; set; }

        public List<Movie> Movies { get; set; }
    }
}
