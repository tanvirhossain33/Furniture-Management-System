using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Furniture_Management_System.Models
{
    public class Home
    {
        public int Id { get; set; }

        [Required]
        public string Phone { get; set; }

        [Required]
        public string Address { get; set; }

        public virtual List<Furniture> Furnitures { get; set; }

    }
}