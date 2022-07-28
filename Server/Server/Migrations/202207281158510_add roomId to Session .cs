namespace Server.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addroomIdtoSession : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.SessionDbs", "RoomId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.SessionDbs", "RoomId");
        }
    }
}
