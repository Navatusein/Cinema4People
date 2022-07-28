namespace Server.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ActorDbAddFirstandLastName : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ActorDbs", "ActorFirstName", c => c.String());
            AddColumn("dbo.ActorDbs", "ActorLastName", c => c.String());
            DropColumn("dbo.ActorDbs", "ActorName");
            DropColumn("dbo.ActorDbs", "ActorRole");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ActorDbs", "ActorRole", c => c.String());
            AddColumn("dbo.ActorDbs", "ActorName", c => c.String());
            DropColumn("dbo.ActorDbs", "ActorLastName");
            DropColumn("dbo.ActorDbs", "ActorFirstName");
        }
    }
}
