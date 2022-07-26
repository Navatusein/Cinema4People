namespace Server.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddActorToMovieDbId : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ActorDbs", "ActorToMovieDbId", c => c.Int(nullable: false));
            AddColumn("dbo.MovieDbs", "ActorToMovieDbId", c => c.Int(nullable: false));
            DropColumn("dbo.ActorDbs", "ActorToMovieId");
            DropColumn("dbo.MovieDbs", "ActorToMovieId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.MovieDbs", "ActorToMovieId", c => c.Int(nullable: false));
            AddColumn("dbo.ActorDbs", "ActorToMovieId", c => c.Int(nullable: false));
            DropColumn("dbo.MovieDbs", "ActorToMovieDbId");
            DropColumn("dbo.ActorDbs", "ActorToMovieDbId");
        }
    }
}
