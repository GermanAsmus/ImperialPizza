namespace PizzaMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial3 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Pedidoes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Fecha = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.LineaPedidoes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Cantidad = c.Int(nullable: false),
                        Pedido_ID = c.Int(),
                        Pizza_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Pedidoes", t => t.Pedido_ID)
                .ForeignKey("dbo.Pizzas", t => t.Pizza_ID)
                .Index(t => t.Pedido_ID)
                .Index(t => t.Pizza_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.LineaPedidoes", "Pizza_ID", "dbo.Pizzas");
            DropForeignKey("dbo.LineaPedidoes", "Pedido_ID", "dbo.Pedidoes");
            DropIndex("dbo.LineaPedidoes", new[] { "Pizza_ID" });
            DropIndex("dbo.LineaPedidoes", new[] { "Pedido_ID" });
            DropTable("dbo.LineaPedidoes");
            DropTable("dbo.Pedidoes");
        }
    }
}
