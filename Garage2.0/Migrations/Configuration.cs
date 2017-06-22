namespace Garage2._0.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;


    internal sealed class Configuration : DbMigrationsConfiguration<Garage2._0.DataAccess.GarageContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Garage2._0.DataAccess.GarageContext context)
        {
            context.Members.AddOrUpdate(
                pv => pv.Id,
                new Models.Member { Name = "Adam", Membershipnumber = "1111", Phonenumber = "070 555 666", Address = "City" },
                new Models.Member { Name = "Arch", Membershipnumber = "1211", Phonenumber = "071 555 666", Address = "City" },
                new Models.Member { Name = "Vega", Membershipnumber = "1131", Phonenumber = "072 555 666", Address = "City" },
                new Models.Member { Name = "Lena", Membershipnumber = "1151", Phonenumber = "073 555 666", Address = "City" },
                new Models.Member { Name = "Filip", Membershipnumber = "1611", Phonenumber = "076 555 666", Address = "City" },
                new Models.Member { Name = "Karl", Membershipnumber = "1811", Phonenumber = "077 555 667", Address = "City" },
                new Models.Member { Name = "Lena", Membershipnumber = "6734", Phonenumber = "070 555 686", Address = "City" },
                new Models.Member { Name = "Lida", Membershipnumber = "3426", Phonenumber = "070 555 866", Address = "City" },
                new Models.Member { Name = "Carl", Membershipnumber = "4652", Phonenumber = "070 558 666", Address = "City" },
                new Models.Member { Name = "Flin", Membershipnumber = "3267", Phonenumber = "070 585 666", Address = "City" },
                new Models.Member { Name = "Alex", Membershipnumber = "1287", Phonenumber = "070 955 666", Address = "City" },
                new Models.Member { Name = "Gerd", Membershipnumber = "8833", Phonenumber = "070 595 666", Address = "City" },
                new Models.Member { Name = "Jana", Membershipnumber = "5566", Phonenumber = "070 559 666", Address = "City" },
                new Models.Member { Name = "Kent", Membershipnumber = "5432", Phonenumber = "070 555 966", Address = "City" },
                new Models.Member { Name = "Anna", Membershipnumber = "4567", Phonenumber = "070 555 696", Address = "City" },
                new Models.Member { Name = "Bert", Membershipnumber = "1234", Phonenumber = "070 555 669", Address = "Alby" }
                );


            //context.ParkedVehicles.AddOrUpdate(

            //    pv => pv.RegNumber,
            //    new Models.ParkedVehicle { TypeOfVehicle = Car, RegNumber = "QSW098", Brand = "BMW", Model = "520d", Color = "Svart", NoOfWheels = 4, CheckInTime = DateTime.Now },
            //    new Models.ParkedVehicle { TypeOfVehicle = Car, RegNumber = "EDC321", Brand = "FIAT", Model = "500L", Color = "Gul", NoOfWheels = 4, CheckInTime = DateTime.Now },
            //    new Models.ParkedVehicle { TypeOfVehicle = Car, RegNumber = "AQR564", Brand = "VW", Model = "Passat", Color = "Silver", NoOfWheels = 4, CheckInTime = DateTime.Now },

            //    new Models.ParkedVehicle { TypeOfVehicle = Bus, RegNumber = "DSL675", Brand = "Scania", Model = "DC13", Color = "Vit", NoOfWheels = 6, CheckInTime = DateTime.Now },
            //    new Models.ParkedVehicle { TypeOfVehicle = Boat, RegNumber = "ADKN456", Brand = "Flipper", Model = "F800R", Color = "Blå", NoOfWheels = 0, CheckInTime = DateTime.Now },
            //    new Models.ParkedVehicle { TypeOfVehicle = Airplane, RegNumber = "NAB900", Brand = "Cessna", Model = "402", Color = "Vit", NoOfWheels = 4, CheckInTime = DateTime.Now },

            //    new Models.ParkedVehicle { TypeOfVehicle = Motorcycle, RegNumber = "GHJ789", Brand = "BMW", Model = "F800R", Color = "Svart", NoOfWheels = 2, CheckInTime = DateTime.Now },
            //    new Models.ParkedVehicle { TypeOfVehicle = Motorcycle, RegNumber = "AHJ090", Brand = "Harley-Davidson", Model = "500L", Color = "Gul", NoOfWheels = 2, CheckInTime = DateTime.Now },
            //    new Models.ParkedVehicle { TypeOfVehicle = Airplane, RegNumber = "JBB007", Brand = "Concorde", Model = "C33", Color = "Vit", NoOfWheels = 16, CheckInTime = DateTime.Now },

            //    new Models.ParkedVehicle { TypeOfVehicle = Bus, RegNumber = "TUR333", Brand = "Scania", Model = "S2000", Color = "Vit", NoOfWheels = 8, CheckInTime = DateTime.Now },
            //    new Models.ParkedVehicle { TypeOfVehicle = Boat, RegNumber = "SNE897", Brand = "Flipper", Model = "F800R", Color = "Blå", NoOfWheels = 0, CheckInTime = DateTime.Now },
            //    new Models.ParkedVehicle { TypeOfVehicle = Airplane, RegNumber = "DIN999", Brand = "Cessna", Model = "402", Color = "Vit", NoOfWheels = 2, CheckInTime = DateTime.Now },

            //    new Models.ParkedVehicle { TypeOfVehicle = Car, RegNumber = "FRU752", Brand = "Ferrari", Model = "F12", Color = "Röd", NoOfWheels = 4, CheckInTime = DateTime.Now },
            //    new Models.ParkedVehicle { TypeOfVehicle = Car, RegNumber = "MAN222", Brand = "Aston Martin", Model = "500L", Color = "Gul", NoOfWheels = 4, CheckInTime = DateTime.Now },
            //    new Models.ParkedVehicle { TypeOfVehicle = Car, RegNumber = "WWW333", Brand = "VW", Model = "Golf", Color = "Grön", NoOfWheels = 4, CheckInTime = DateTime.Now },

            //    new Models.ParkedVehicle { TypeOfVehicle = Bus, RegNumber = "HIP444", Brand = "Scania", Model = "DC13", Color = "Brun", NoOfWheels = 8, CheckInTime = DateTime.Now },
            //    new Models.ParkedVehicle { TypeOfVehicle = Boat, RegNumber = "HOP555", Brand = "Uttern", Model = "U127", Color = "Grå", NoOfWheels = 0, CheckInTime = DateTime.Now },
            //    new Models.ParkedVehicle { TypeOfVehicle = Airplane, RegNumber = "SAS123", Brand = "Fokker", Model = "F-28", Color = "Vit", NoOfWheels = 16, CheckInTime = DateTime.Now },

            //    new Models.ParkedVehicle { TypeOfVehicle = Car, RegNumber = "FIN753", Brand = "BMW", Model = "F800R", Color = "Svart", NoOfWheels = 4, CheckInTime = DateTime.Now },
            //    new Models.ParkedVehicle { TypeOfVehicle = Car, RegNumber = "LOS987", Brand = "FIAT", Model = "500L", Color = "Gul", NoOfWheels = 4, CheckInTime = DateTime.Now },
            //    new Models.ParkedVehicle { TypeOfVehicle = Car, RegNumber = "BIL144", Brand = "Volvo", Model = "144", Color = "Vit", NoOfWheels = 4, CheckInTime = DateTime.Now },

            //    new Models.ParkedVehicle { TypeOfVehicle = Motorcycle, RegNumber = "DUC565", Brand = "Ducati", Model = "D1200R", Color = "Svart", NoOfWheels = 2, CheckInTime = DateTime.Now },
            //    new Models.ParkedVehicle { TypeOfVehicle = Motorcycle, RegNumber = "HUS987", Brand = "Husqvarna", Model = "500cc", Color = "Gul", NoOfWheels = 2, CheckInTime = DateTime.Now },
            //    new Models.ParkedVehicle { TypeOfVehicle = Motorcycle, RegNumber = "HON787", Brand = "Honda", Model = "750", Color = "Grön", NoOfWheels = 2, CheckInTime = DateTime.Now },

            //    new Models.ParkedVehicle { TypeOfVehicle = Boat, RegNumber = "BÅT003", Brand = "Buster", Model = "DC13", Color = "Vit", NoOfWheels = 0, CheckInTime = DateTime.Now },
            //    new Models.ParkedVehicle { TypeOfVehicle = Boat, RegNumber = "ZXY321", Brand = "Princess", Model = "P44", Color = "Blå", NoOfWheels = 0, CheckInTime = DateTime.Now },
            //    new Models.ParkedVehicle { TypeOfVehicle = Airplane, RegNumber = "QTY555", Brand = "Boeing", Model = "747", Color = "Vit", NoOfWheels = 20, CheckInTime = DateTime.Now }
            //    );
        }

    }
}
