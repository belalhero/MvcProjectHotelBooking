namespace MyRoomBookingProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class belal33 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.BookingInfoes", "TotalAmount");
        }
        
        public override void Down()
        {
            AddColumn("dbo.BookingInfoes", "TotalAmount", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
    }
}
