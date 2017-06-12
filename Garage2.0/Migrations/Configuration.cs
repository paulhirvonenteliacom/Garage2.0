namespace Garage2._0.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using static Garage2._0.Enum.TypeOfVehicle;

    internal sealed class Configuration : DbMigrationsConfiguration<Garage2._0.DataAccess.GarageContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Garage2._0.DataAccess.GarageContext context)
        {
            context.ParkedVehicles.AddOrUpdate(

                pv => pv.RegNumber,
                new Models.ParkedVehicle { TypeOfVehicle =  Car, RegNumber = "QSW098", Brand = "BMW", Model = "F800R", Color = "Black", NoOfWheels = 4 },
                new Models.ParkedVehicle { TypeOfVehicle = Car, RegNumber = "EDC321", Brand = "FIAT", Model = "500L", Color = "Yellow", NoOfWheels = 4 },
                new Models.ParkedVehicle { TypeOfVehicle = Car, RegNumber = "AQR564", Brand = "VW", Model = "Passat", Color = "Silver", NoOfWheels = 4 },

                new Models.ParkedVehicle { TypeOfVehicle = Bus, RegNumber = "DSL675", Brand = "Scania", Model = "DC13", Color = "White", NoOfWheels = 6 },
                new Models.ParkedVehicle { TypeOfVehicle = Boat, RegNumber = "ADKN2592", Brand = "Home", Model = "F800R", Color = "Blue", NoOfWheels = 0 },
                new Models.ParkedVehicle { TypeOfVehicle = Airplane, RegNumber = "NAB810BW", Brand = "Cessna", Model = "402", Color = "White", NoOfWheels = 4}
                );
        }

    }
}
