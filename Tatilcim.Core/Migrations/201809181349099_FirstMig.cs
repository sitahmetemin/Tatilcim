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
                        DeletedAt = c.DateTime(nullable: false),
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
                        AuthorityId = c.Int(),
                        CreatedAt = c.DateTime(nullable: false),
                        UpdatedAt = c.DateTime(nullable: false),
                        DeletedAt = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Authorities", t => t.AuthorityId)
                .Index(t => t.AuthorityId);
            
            CreateTable(
                "dbo.Countries",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CreatedAt = c.DateTime(nullable: false),
                        UpdatedAt = c.DateTime(nullable: false),
                        DeletedAt = c.DateTime(nullable: false),
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
                        DeletedAt = c.DateTime(nullable: false),
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
                        DeletedAt = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
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
                        Yıldız = c.String(),
                        CarPark = c.Boolean(nullable: false),
                        Restaurant = c.Boolean(nullable: false),
                        Bar = c.Boolean(nullable: false),
                        Spa = c.Boolean(nullable: false),
                        Pool = c.Boolean(nullable: false),
                        Gym = c.Boolean(nullable: false),
                        RoomService = c.Boolean(nullable: false),
                        Breakfast = c.Boolean(nullable: false),
                        Wifi = c.Boolean(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                        UpdatedAt = c.DateTime(nullable: false),
                        DeletedAt = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Reservations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PersonCount = c.Int(nullable: false),
                        EntryDate = c.DateTime(nullable: false),
                        ReleaseDate = c.DateTime(nullable: false),
                        OtelId = c.Int(),
                        RoomId = c.Int(),
                        CreatedAt = c.DateTime(nullable: false),
                        UpdatedAt = c.DateTime(nullable: false),
                        DeletedAt = c.DateTime(nullable: false),
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
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PersonCount = c.Int(nullable: false),
                        Tel = c.Boolean(nullable: false),
                        TV = c.Boolean(nullable: false),
                        Clima = c.Boolean(nullable: false),
                        MiniBar = c.Boolean(nullable: false),
                        Jakuzi = c.Boolean(nullable: false),
                        Balcony = c.Boolean(nullable: false),
                        Bathroom = c.Boolean(nullable: false),
                        Dryer = c.Boolean(nullable: false),
                        OtelId = c.Int(),
                        CreatedAt = c.DateTime(nullable: false),
                        UpdatedAt = c.DateTime(nullable: false),
                        DeletedAt = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Otels", t => t.OtelId)
                .Index(t => t.OtelId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Reservations", "RoomId", "dbo.Rooms");
            DropForeignKey("dbo.Rooms", "OtelId", "dbo.Otels");
            DropForeignKey("dbo.Reservations", "OtelId", "dbo.Otels");
            DropForeignKey("dbo.Districts", "ProvinceId", "dbo.Provinces");
            DropForeignKey("dbo.Users", "AuthorityId", "dbo.Authorities");
            DropIndex("dbo.Rooms", new[] { "OtelId" });
            DropIndex("dbo.Reservations", new[] { "RoomId" });
            DropIndex("dbo.Reservations", new[] { "OtelId" });
            DropIndex("dbo.Districts", new[] { "ProvinceId" });
            DropIndex("dbo.Users", new[] { "AuthorityId" });
            DropTable("dbo.Rooms");
            DropTable("dbo.Reservations");
            DropTable("dbo.Otels");
            DropTable("dbo.Provinces");
            DropTable("dbo.Districts");
            DropTable("dbo.Countries");
            DropTable("dbo.Users");
            DropTable("dbo.Authorities");
        }
    }
}
