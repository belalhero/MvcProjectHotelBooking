namespace MyRoomBookingProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class eie2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BookingInfoes",
                c => new
                    {
                        BookingInfoID = c.Int(nullable: false, identity: true),
                        HotelName = c.String(),
                        RoomType = c.String(),
                        MaxNumberOfGuest = c.Int(nullable: false),
                        NumberOfBed = c.Int(nullable: false),
                        NumberOfDays = c.Int(nullable: false),
                        PricePerNight = c.Decimal(nullable: false, precision: 18, scale: 2),
                        TotalAmount = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.BookingInfoID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.BookingInfoes");
        }
    }
}
