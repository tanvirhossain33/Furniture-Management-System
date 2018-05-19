using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Furniture_Management_System.Models
{
    public class FurnitureType
    {
        public int Id { get; set; }
        [Required]
        public string Type { get; set; }

        public virtual List<Furniture> Furnitures { get; set; }

    }
}