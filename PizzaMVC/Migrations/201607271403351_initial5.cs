namespace PizzaMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial5 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Pedidoes", "Hora", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Pedidoes", "Hora");
        }
    }
}
