namespace Tatilcim.Core.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class otelEdit : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Otels", "Star", c => c.String());
            DropColumn("dbo.Otels", "Yıldız");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Otels", "Yıldız", c => c.String());
            DropColumn("dbo.Otels", "Star");
        }
    }
}
