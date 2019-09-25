namespace MyRoomBookingProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class hero1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.BookingInfoes", "GuestName", c => c.String());
            AddColumn("dbo.BookingInfoes", "MobileNo", c => c.String());
            AddColumn("dbo.BookingInfoes", "CheckIn", c => c.DateTime(nullable: false));
            AddColumn("dbo.BookingInfoes", "ExpectedCheckOut", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.BookingInfoes", "ExpectedCheckOut");
            DropColumn("dbo.BookingInfoes", "CheckIn");
            DropColumn("dbo.BookingInfoes", "MobileNo");
            DropColumn("dbo.BookingInfoes", "GuestName");
        }
    }
}
