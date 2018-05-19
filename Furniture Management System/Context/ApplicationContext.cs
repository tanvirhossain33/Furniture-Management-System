using Furniture_Management_System.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Furniture_Management_System.Context
{
    public class ApplicationContext : DbContext
    {

        public DbSet<Furniture> furnitures { get; set; }
        public DbSet<FurnitureType> furnitureTypes { get; set; }
        public DbSet<Home> homes { get; set; }
         
    }
}