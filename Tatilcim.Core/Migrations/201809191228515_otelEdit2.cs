namespace Tatilcim.Core.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class otelEdit2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Otels", "Star", c => c.Int(nullable: false));
            AlterColumn("dbo.Otels", "CarPark", c => c.String());
            AlterColumn("dbo.Otels", "Restaurant", c => c.String());
            AlterColumn("dbo.Otels", "Bar", c => c.String());
            AlterColumn("dbo.Otels", "Spa", c => c.String());
            AlterColumn("dbo.Otels", "Pool", c => c.String());
            AlterColumn("dbo.Otels", "Gym", c => c.String());
            AlterColumn("dbo.Otels", "RoomService", c => c.String());
            AlterColumn("dbo.Otels", "Breakfast", c => c.String());
            AlterColumn("dbo.Otels", "Wifi", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Otels", "Wifi", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Otels", "Breakfast", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Otels", "RoomService", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Otels", "Gym", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Otels", "Pool", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Otels", "Spa", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Otels", "Bar", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Otels", "Restaurant", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Otels", "CarPark", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Otels", "Star", c => c.String());
        }
    }
}
