namespace Furniture_Management_System.Migrations
{
    using Furniture_Management_System.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Furniture_Management_System.Context.ApplicationContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Furniture_Management_System.Context.ApplicationContext context)
        {
            context.homes.AddOrUpdate(

                new Home { Phone = "01817408048", Address = "Dhanmondi" },
                new Home { Phone = "01817444444", Address = "Mohakhali" },
                new Home { Phone = "01817555555", Address = "Uttora" },
                new Home { Phone = "01817666666", Address = "Banani" },
                new Home { Phone = "01817777777", Address = "Gulshan" }
            );

            context.furnitureTypes.AddOrUpdate(

                new FurnitureType { Type = "Chair" },
                new FurnitureType { Type = "Bench" },
                new FurnitureType { Type = "Bed" },
                new FurnitureType { Type = "Table" },
                new FurnitureType { Type = "Closet" }
            );

            //context.furnitures.AddOrUpdate(

            //    new Furniture { Weight = "3 KG", FurnitureTypeId = 1, HomeId = 1 },
            //    new Furniture { Weight = "1 KG", FurnitureTypeId = 2, HomeId = 3 },
            //    new Furniture { Weight = "10 KG", FurnitureTypeId = 3, HomeId = 2 },
            //    new Furniture { Weight = "5 KG", FurnitureTypeId = 4, HomeId = 5 },
            //    new Furniture { Weight = "20 KG", FurnitureTypeId = 5, HomeId = 1 }


            //);
        }
    }
}
