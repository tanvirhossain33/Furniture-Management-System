using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Furniture_Management_System.Models
{
    public class Furniture
    {
        public int Id { get; set; }

        [Required]
        public string Weight { get; set; }


        public int FurnitureTypeId { get; set; }
        public int HomeId { get; set; }

        [ForeignKey("FurnitureTypeId")]
        public virtual FurnitureType FurnitureTyle { get; set; }

        [ForeignKey("HomeId")]
        public virtual Home Home { get; set; }


    }
}