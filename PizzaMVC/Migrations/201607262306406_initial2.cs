namespace PizzaMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Events", "Fecha", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Events", "Fecha", c => c.DateTime(nullable: false));
        }
    }
}
