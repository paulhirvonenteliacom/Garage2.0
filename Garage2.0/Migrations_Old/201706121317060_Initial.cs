namespace Garage2._0.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ParkedVehicles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TypeOfVehicle = c.Int(nullable: false),
                        RegNumber = c.String(nullable: false, maxLength: 16),
                        Color = c.String(maxLength: 30),
                        NoOfWheels = c.Int(nullable: false),
                        Brand = c.String(maxLength: 30),
                        Model = c.String(maxLength: 30),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ParkedVehicles");
        }
    }
}
