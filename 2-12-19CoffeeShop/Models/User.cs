using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _2_12_19CoffeeShop.Models
{
    public class User
    {
        [Required] // attributes 
        [RegularExpression("^[A-Z]+[A-z]{1,30}$")]
        public string FirstName { get; set; }

        [Required]
        [RegularExpression("^[a-zA-Z]{2,}$")]
        public string LastName { get; set; }

        [Required]
        [RegularExpression(@"^([A-z0-9\.]{5,30})@([A-z]{5,10})\.([a-z]{2,3})$")]
        public string Email { get; set; }

        [Required]
        [RegularExpression(@"^\d{3}-?\d{3}-?\d{4}$")]
        public string PhoneNumber { get; set; }

        [Required]
        [RegularExpression(@"^[A-z0-9]{8,30}$")]
        public string Password { get; set; }

        public DateTime BirthDate { get; set; }


    }
}