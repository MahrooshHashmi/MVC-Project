using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Ead_MVC.Models
{
    public class User
    {
        [Required]
        public String Email { get; set; }
        [Required]
        public String  Password { get; set; }
    }
}