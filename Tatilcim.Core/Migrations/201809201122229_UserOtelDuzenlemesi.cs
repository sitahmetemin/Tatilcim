namespace Tatilcim.Core.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UserOtelDuzenlemesi : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "OtelId", c => c.Int());
            CreateIndex("dbo.Users", "OtelId");
            AddForeignKey("dbo.Users", "OtelId", "dbo.Otels", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Users", "OtelId", "dbo.Otels");
            DropIndex("dbo.Users", new[] { "OtelId" });
            DropColumn("dbo.Users", "OtelId");
        }
    }
}
