namespace Tatilcim.Core.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ReservationEdit : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Reservations", "Status", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Reservations", "Status");
        }
    }
}
