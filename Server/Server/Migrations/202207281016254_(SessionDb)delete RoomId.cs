namespace Server.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SessionDbdeleteRoomId : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.SessionDbs", "RoomId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.SessionDbs", "RoomId", c => c.Int(nullable: false));
        }
    }
}
