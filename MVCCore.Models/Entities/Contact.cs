using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MVCCore.Models.Entities
{
    public class Contact
    {
        [Display(Name = "Contact Id")]
        public int ContactId { get; set; }

        [Required(ErrorMessage = "Quiero ser negro")]
        [Display(Name = "Firstname")]
        public string Firstname { get; set; }

        [Display(Name = "Lastname")]
        public string Lastname { get; set; }

        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Display(Name = "Phone")]
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }

        [Display(Name = "City")]
        [Required]
        public string City { get; set; }
    }
}
