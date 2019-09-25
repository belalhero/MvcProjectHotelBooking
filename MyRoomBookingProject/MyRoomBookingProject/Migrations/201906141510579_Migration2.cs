namespace MyRoomBookingProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Migration2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Rooms",
                c => new
                    {
                        RoomID = c.Int(nullable: false, identity: true),
                        HotelID = c.Int(nullable: false),
                        RoomTypeID = c.Int(nullable: false),
                        MaxCapacity = c.Int(nullable: false),
                        NumberOfBed = c.Int(nullable: false),
                        Description = c.String(),
                        PricePerNight = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.RoomID)
                .ForeignKey("dbo.Hotels", t => t.HotelID, cascadeDelete: true)
                .ForeignKey("dbo.RoomTypes", t => t.RoomTypeID, cascadeDelete: true)
                .Index(t => t.HotelID)
                .Index(t => t.RoomTypeID);
            
            CreateTable(
                "dbo.RoomTypes",
                c => new
                    {
                        RoomTypeID = c.Int(nullable: false, identity: true),
                        RoomTypeName = c.String(),
                    })
                .PrimaryKey(t => t.RoomTypeID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Rooms", "RoomTypeID", "dbo.RoomTypes");
            DropForeignKey("dbo.Rooms", "HotelID", "dbo.Hotels");
            DropIndex("dbo.Rooms", new[] { "RoomTypeID" });
            DropIndex("dbo.Rooms", new[] { "HotelID" });
            DropTable("dbo.RoomTypes");
            DropTable("dbo.Rooms");
        }
    }
}
