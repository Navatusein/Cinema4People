namespace Server.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class roomSeatsandTypes : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.RoomSeatDbs", "CinemaRoom_Id", "dbo.CinemaRoomDbs");
            DropForeignKey("dbo.RoomTypeDbs", "CinemaRoom_Id", "dbo.CinemaRoomDbs");
            DropIndex("dbo.RoomSeatDbs", new[] { "CinemaRoom_Id" });
            DropIndex("dbo.RoomTypeDbs", new[] { "CinemaRoom_Id" });
            RenameColumn(table: "dbo.RoomSeatDbs", name: "CinemaRoom_Id", newName: "CinemaRoomDbId");
            RenameColumn(table: "dbo.RoomTypeDbs", name: "CinemaRoom_Id", newName: "CinemaRoomDbId");
            AlterColumn("dbo.RoomSeatDbs", "CinemaRoomDbId", c => c.Int(nullable: false));
            AlterColumn("dbo.RoomTypeDbs", "CinemaRoomDbId", c => c.Int(nullable: false));
            CreateIndex("dbo.RoomSeatDbs", "CinemaRoomDbId");
            CreateIndex("dbo.RoomTypeDbs", "CinemaRoomDbId");
            AddForeignKey("dbo.RoomSeatDbs", "CinemaRoomDbId", "dbo.CinemaRoomDbs", "Id", cascadeDelete: true);
            AddForeignKey("dbo.RoomTypeDbs", "CinemaRoomDbId", "dbo.CinemaRoomDbs", "Id", cascadeDelete: true);
            DropColumn("dbo.CinemaRoomDbs", "RoomSeatsId");
            DropColumn("dbo.CinemaRoomDbs", "RoomTypeId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.CinemaRoomDbs", "RoomTypeId", c => c.Int(nullable: false));
            AddColumn("dbo.CinemaRoomDbs", "RoomSeatsId", c => c.Int(nullable: false));
            DropForeignKey("dbo.RoomTypeDbs", "CinemaRoomDbId", "dbo.CinemaRoomDbs");
            DropForeignKey("dbo.RoomSeatDbs", "CinemaRoomDbId", "dbo.CinemaRoomDbs");
            DropIndex("dbo.RoomTypeDbs", new[] { "CinemaRoomDbId" });
            DropIndex("dbo.RoomSeatDbs", new[] { "CinemaRoomDbId" });
            AlterColumn("dbo.RoomTypeDbs", "CinemaRoomDbId", c => c.Int());
            AlterColumn("dbo.RoomSeatDbs", "CinemaRoomDbId", c => c.Int());
            RenameColumn(table: "dbo.RoomTypeDbs", name: "CinemaRoomDbId", newName: "CinemaRoom_Id");
            RenameColumn(table: "dbo.RoomSeatDbs", name: "CinemaRoomDbId", newName: "CinemaRoom_Id");
            CreateIndex("dbo.RoomTypeDbs", "CinemaRoom_Id");
            CreateIndex("dbo.RoomSeatDbs", "CinemaRoom_Id");
            AddForeignKey("dbo.RoomTypeDbs", "CinemaRoom_Id", "dbo.CinemaRoomDbs", "Id");
            AddForeignKey("dbo.RoomSeatDbs", "CinemaRoom_Id", "dbo.CinemaRoomDbs", "Id");
        }
    }
}
