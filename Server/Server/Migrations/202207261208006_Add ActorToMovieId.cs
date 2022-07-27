namespace Server.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddActorToMovieId : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ActorDbs", "ActorToMovieId", c => c.Int(nullable: false));
            AddColumn("dbo.MovieDbs", "ActorToMovieId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.MovieDbs", "ActorToMovieId");
            DropColumn("dbo.ActorDbs", "ActorToMovieId");
        }
    }
}
