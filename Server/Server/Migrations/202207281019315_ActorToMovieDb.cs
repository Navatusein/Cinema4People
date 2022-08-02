namespace Server.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ActorToMovieDb : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.ActorToMovieDbs", "ActorsId");
            DropColumn("dbo.ActorToMovieDbs", "MoviesId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ActorToMovieDbs", "MoviesId", c => c.Int(nullable: false));
            AddColumn("dbo.ActorToMovieDbs", "ActorsId", c => c.Int(nullable: false));
        }
    }
}
