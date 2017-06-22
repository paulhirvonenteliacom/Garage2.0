namespace Garage2._0.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TypeOfVehicle : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.VehicleTypes", "TypeOfVehicle", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.VehicleTypes", "TypeOfVehicle", c => c.Int());
        }
    }
}
