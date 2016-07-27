namespace PizzaMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial4 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Pedidoes", "Cliente", c => c.String());
            AddColumn("dbo.Pedidoes", "Direccion", c => c.String());
            AddColumn("dbo.Pedidoes", "Precio", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.LineaPedidoes", "Precio", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.Pizzas", "Precio", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Pizzas", "Precio", c => c.Single(nullable: false));
            DropColumn("dbo.LineaPedidoes", "Precio");
            DropColumn("dbo.Pedidoes", "Precio");
            DropColumn("dbo.Pedidoes", "Direccion");
            DropColumn("dbo.Pedidoes", "Cliente");
        }
    }
}
