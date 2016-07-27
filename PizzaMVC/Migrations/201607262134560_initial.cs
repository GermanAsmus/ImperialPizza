namespace PizzaMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Events", "Pizzas", c => c.String());
            AddColumn("dbo.Pizzas", "Receta", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Pizzas", "Receta");
            DropColumn("dbo.Events", "Pizzas");
        }
    }
}
