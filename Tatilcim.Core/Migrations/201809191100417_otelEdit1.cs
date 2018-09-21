namespace Tatilcim.Core.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class otelEdit1 : DbMigration
    {
        public override void Up()
        {
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
            
            AddColumn("dbo.Otels", "Cover", c => c.String());
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Albums", "RoomId", "dbo.Rooms");
            DropForeignKey("dbo.Albums", "OtelId", "dbo.Otels");
            DropIndex("dbo.Albums", new[] { "RoomId" });
            DropIndex("dbo.Albums", new[] { "OtelId" });
            DropColumn("dbo.Otels", "Cover");
            DropTable("dbo.Albums");
        }
    }
}
