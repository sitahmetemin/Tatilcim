namespace Tatilcim.Core.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FirstMig : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Authorities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Command = c.String(),
                        CreatedAt = c.DateTime(nullable: false),
                        UpdatedAt = c.DateTime(nullable: false),
                        DeletedAt = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        DisplayName = c.String(),
                        Email = c.String(),
                        Password = c.String(),
                        Image = c.String(),
                        Description = c.String(),
                        AuthorityId = c.Int(),
                        OtelId = c.Int(),
                        CreatedAt = c.DateTime(nullable: false),
                        UpdatedAt = c.DateTime(nullable: false),
                        DeletedAt = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Authorities", t => t.AuthorityId)
                .ForeignKey("dbo.Otels", t => t.OtelId)
                .Index(t => t.AuthorityId)
                .Index(t => t.OtelId);
            
            CreateTable(
                "dbo.Otels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Address = c.String(),
                        Email = c.String(),
                        Description = c.String(),
                        Tel = c.String(),
                        Star = c.Int(nullable: false),
                        Cover = c.String(),
                        Status = c.Boolean(nullable: false),
                        CarPark = c.String(),
                        Restaurant = c.String(),
                        Bar = c.String(),
                        Spa = c.String(),
                        Pool = c.String(),
                        Gym = c.String(),
                        RoomService = c.String(),
                        Breakfast = c.String(),
                        Wifi = c.String(),
                        CreatedAt = c.DateTime(nullable: false),
                        UpdatedAt = c.DateTime(nullable: false),
                        DeletedAt = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Albums",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Image = c.String(),
                        OtelId = c.Int(),
                        RoomId = c.Int(),
                        CreatedAt = c.DateTime(nullable: false),
                        UpdatedAt = c.DateTime(nullable: false),
                        DeletedAt = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Otels", t => t.OtelId)
                .ForeignKey("dbo.Rooms", t => t.RoomId)
                .Index(t => t.OtelId)
                .Index(t => t.RoomId);
            
            CreateTable(
                "dbo.Rooms",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Cover = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PersonCount = c.Int(nullable: false),
                        Tel = c.String(),
                        TV = c.String(),
                        Clima = c.String(),
                        MiniBar = c.String(),
                        Jakuzi = c.String(),
                        Balcony = c.String(),
                        Bathroom = c.String(),
                        Dryer = c.String(),
                        OtelId = c.Int(),
                        CreatedAt = c.DateTime(nullable: false),
                        UpdatedAt = c.DateTime(nullable: false),
                        DeletedAt = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Otels", t => t.OtelId)
                .Index(t => t.OtelId);
            
            CreateTable(
                "dbo.Reservations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PersonCount = c.Int(nullable: false),
                        EntryDate = c.DateTime(nullable: false),
                        ReleaseDate = c.DateTime(nullable: false),
                        UserId = c.Int(),
                        OtelId = c.Int(),
                        RoomId = c.Int(),
                        CreatedAt = c.DateTime(nullable: false),
                        UpdatedAt = c.DateTime(nullable: false),
                        DeletedAt = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Otels", t => t.OtelId)
                .ForeignKey("dbo.Rooms", t => t.RoomId)
                .ForeignKey("dbo.Users", t => t.UserId)
                .Index(t => t.UserId)
                .Index(t => t.OtelId)
                .Index(t => t.RoomId);
            
            CreateTable(
                "dbo.Countries",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CreatedAt = c.DateTime(nullable: false),
                        UpdatedAt = c.DateTime(nullable: false),
                        DeletedAt = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Districts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        ProvinceId = c.Int(),
                        CreatedAt = c.DateTime(nullable: false),
                        UpdatedAt = c.DateTime(nullable: false),
                        DeletedAt = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Provinces", t => t.ProvinceId)
                .Index(t => t.ProvinceId);
            
            CreateTable(
                "dbo.Provinces",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        CreatedAt = c.DateTime(nullable: false),
                        UpdatedAt = c.DateTime(nullable: false),
                        DeletedAt = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Districts", "ProvinceId", "dbo.Provinces");
            DropForeignKey("dbo.Users", "OtelId", "dbo.Otels");
            DropForeignKey("dbo.Reservations", "UserId", "dbo.Users");
            DropForeignKey("dbo.Reservations", "RoomId", "dbo.Rooms");
            DropForeignKey("dbo.Reservations", "OtelId", "dbo.Otels");
            DropForeignKey("dbo.Rooms", "OtelId", "dbo.Otels");
            DropForeignKey("dbo.Albums", "RoomId", "dbo.Rooms");
            DropForeignKey("dbo.Albums", "OtelId", "dbo.Otels");
            DropForeignKey("dbo.Users", "AuthorityId", "dbo.Authorities");
            DropIndex("dbo.Districts", new[] { "ProvinceId" });
            DropIndex("dbo.Reservations", new[] { "RoomId" });
            DropIndex("dbo.Reservations", new[] { "OtelId" });
            DropIndex("dbo.Reservations", new[] { "UserId" });
            DropIndex("dbo.Rooms", new[] { "OtelId" });
            DropIndex("dbo.Albums", new[] { "RoomId" });
            DropIndex("dbo.Albums", new[] { "OtelId" });
            DropIndex("dbo.Users", new[] { "OtelId" });
            DropIndex("dbo.Users", new[] { "AuthorityId" });
            DropTable("dbo.Provinces");
            DropTable("dbo.Districts");
            DropTable("dbo.Countries");
            DropTable("dbo.Reservations");
            DropTable("dbo.Rooms");
            DropTable("dbo.Albums");
            DropTable("dbo.Otels");
            DropTable("dbo.Users");
            DropTable("dbo.Authorities");
        }
    }
}
