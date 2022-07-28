namespace Server.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add2tablesRoomSeatDbandRoomTypeDb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.RoomSeatDbs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Row = c.Int(nullable: false),
                        Column = c.Int(nullable: false),
                        isEmpty = c.Boolean(nullable: false),
                        CinemaRoom_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.CinemaRoomDbs", t => t.CinemaRoom_Id)
                .Index(t => t.CinemaRoom_Id);
            
            CreateTable(
                "dbo.RoomTypeDbs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Row = c.Int(nullable: false),
                        Price = c.Single(nullable: false),
                        Types = c.String(),
                        CinemaRoom_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.CinemaRoomDbs", t => t.CinemaRoom_Id)
                .Index(t => t.CinemaRoom_Id);
            
            AddColumn("dbo.CinemaRoomDbs", "RoomSeatsId", c => c.Int(nullable: false));
            AddColumn("dbo.CinemaRoomDbs", "RoomTypeId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.RoomTypeDbs", "CinemaRoom_Id", "dbo.CinemaRoomDbs");
            DropForeignKey("dbo.RoomSeatDbs", "CinemaRoom_Id", "dbo.CinemaRoomDbs");
            DropIndex("dbo.RoomTypeDbs", new[] { "CinemaRoom_Id" });
            DropIndex("dbo.RoomSeatDbs", new[] { "CinemaRoom_Id" });
            DropColumn("dbo.CinemaRoomDbs", "RoomTypeId");
            DropColumn("dbo.CinemaRoomDbs", "RoomSeatsId");
            DropTable("dbo.RoomTypeDbs");
            DropTable("dbo.RoomSeatDbs");
        }
    }
}
