using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace PS1.Forms
{
    public class Address
    {   
        [Display(Name="Twoja ulica")]
        [StringLength(60, MinimumLength =5), Required(ErrorMessage ="Uzupełnij to pole")]
        public string Street { get; set; }
        public int Number { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }
    }
}
