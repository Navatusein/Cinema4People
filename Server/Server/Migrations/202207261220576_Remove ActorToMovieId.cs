namespace Server.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveActorToMovieId : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.ActorDbs", "ActorToMovieDbId");
            DropColumn("dbo.MovieDbs", "ActorToMovieDbId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.MovieDbs", "ActorToMovieDbId", c => c.Int(nullable: false));
            AddColumn("dbo.ActorDbs", "ActorToMovieDbId", c => c.Int(nullable: false));
        }
    }
}
