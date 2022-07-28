namespace Server.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class returnActorToMovieDb : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ActorToMovieDbs", "ActorsId", c => c.Int(nullable: false));
            AddColumn("dbo.ActorToMovieDbs", "MoviesId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.ActorToMovieDbs", "MoviesId");
            DropColumn("dbo.ActorToMovieDbs", "ActorsId");
        }
    }
}
