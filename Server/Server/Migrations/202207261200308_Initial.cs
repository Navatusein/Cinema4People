namespace Server.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ActorDbs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ActorName = c.String(),
                        ActorRole = c.String(),
                        ActorPhoto = c.Binary(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ActorToMovieDbs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ActorsId = c.Int(nullable: false),
                        MoviesId = c.Int(nullable: false),
                        Actor_Id = c.Int(),
                        Movie_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ActorDbs", t => t.Actor_Id)
                .ForeignKey("dbo.MovieDbs", t => t.Movie_Id)
                .Index(t => t.Actor_Id)
                .Index(t => t.Movie_Id);
            
            CreateTable(
                "dbo.MovieDbs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        TrailerLink = c.String(),
                        Description = c.String(),
                        Duration = c.Int(nullable: false),
                        Rating = c.Double(nullable: false),
                        Poster = c.Binary(),
                        Genres = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Comments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MovieId = c.Int(nullable: false),
                        Text = c.String(),
                        Movies_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.MovieDbs", t => t.Movies_Id)
                .Index(t => t.Movies_Id);
            
            CreateTable(
                "dbo.ProductDbs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Price = c.Single(nullable: false),
                        Quantity = c.Int(nullable: false),
                        PathImage = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.CinemaRoomDbs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RoomNumber = c.Int(nullable: false),
                        RoomName = c.String(),
                        Price = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SessionDbs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        Time = c.Time(nullable: false, precision: 7),
                        MovieId = c.Int(nullable: false),
                        RoomId = c.Int(nullable: false),
                        CinemaRoom_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.CinemaRoomDbs", t => t.CinemaRoom_Id)
                .ForeignKey("dbo.MovieDbs", t => t.MovieId, cascadeDelete: true)
                .Index(t => t.MovieId)
                .Index(t => t.CinemaRoom_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SessionDbs", "MovieId", "dbo.MovieDbs");
            DropForeignKey("dbo.SessionDbs", "CinemaRoom_Id", "dbo.CinemaRoomDbs");
            DropForeignKey("dbo.Comments", "Movies_Id", "dbo.MovieDbs");
            DropForeignKey("dbo.ActorToMovieDbs", "Movie_Id", "dbo.MovieDbs");
            DropForeignKey("dbo.ActorToMovieDbs", "Actor_Id", "dbo.ActorDbs");
            DropIndex("dbo.SessionDbs", new[] { "CinemaRoom_Id" });
            DropIndex("dbo.SessionDbs", new[] { "MovieId" });
            DropIndex("dbo.Comments", new[] { "Movies_Id" });
            DropIndex("dbo.ActorToMovieDbs", new[] { "Movie_Id" });
            DropIndex("dbo.ActorToMovieDbs", new[] { "Actor_Id" });
            DropTable("dbo.SessionDbs");
            DropTable("dbo.CinemaRoomDbs");
            DropTable("dbo.ProductDbs");
            DropTable("dbo.Comments");
            DropTable("dbo.MovieDbs");
            DropTable("dbo.ActorToMovieDbs");
            DropTable("dbo.ActorDbs");
        }
    }
}
