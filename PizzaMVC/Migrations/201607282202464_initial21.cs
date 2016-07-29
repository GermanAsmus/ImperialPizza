namespace PizzaMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial21 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DetallePedidoes",
                c => new
                    {
                        DetallePedidoID = c.Int(nullable: false, identity: true),
                        PedidoID = c.Int(nullable: false),
                        ProductoID = c.Int(nullable: false),
                        Descripcion = c.String(),
                        Cantidad = c.Single(nullable: false),
                        Precio = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.DetallePedidoID)
                .ForeignKey("dbo.Pedidoes", t => t.PedidoID, cascadeDelete: true)
                .ForeignKey("dbo.Productoes", t => t.ProductoID, cascadeDelete: true)
                .Index(t => t.PedidoID)
                .Index(t => t.ProductoID);
            
            CreateTable(
                "dbo.Pedidoes",
                c => new
                    {
                        PedidoID = c.Int(nullable: false, identity: true),
                        Fecha = c.DateTime(nullable: false),
                        Hora = c.DateTime(nullable: false),
                        Cliente = c.String(),
                        Direccion = c.String(),
                        EstadoPedido = c.Int(nullable: false),
                        LocalidadID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PedidoID)
                .ForeignKey("dbo.Localidads", t => t.LocalidadID, cascadeDelete: true)
                .Index(t => t.LocalidadID);
            
            CreateTable(
                "dbo.Localidads",
                c => new
                    {
                        LocalidadID = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                    })
                .PrimaryKey(t => t.LocalidadID);
            
            CreateTable(
                "dbo.Productoes",
                c => new
                    {
                        ProductoID = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 80),
                        Descripcion = c.String(nullable: false, maxLength: 200),
                        Precio = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Cantidad = c.Single(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.ProductoID);
            
            CreateTable(
                "dbo.DetalleEventoes",
                c => new
                    {
                        DetalleEventoID = c.Int(nullable: false, identity: true),
                        ProductoID = c.Int(nullable: false),
                        EventID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.DetalleEventoID)
                .ForeignKey("dbo.Events", t => t.EventID, cascadeDelete: true)
                .ForeignKey("dbo.Productoes", t => t.ProductoID, cascadeDelete: true)
                .Index(t => t.ProductoID)
                .Index(t => t.EventID);
            
            CreateTable(
                "dbo.Events",
                c => new
                    {
                        EventID = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Descripcion = c.String(),
                        Fecha = c.String(),
                    })
                .PrimaryKey(t => t.EventID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.DetallePedidoes", "ProductoID", "dbo.Productoes");
            DropForeignKey("dbo.DetalleEventoes", "ProductoID", "dbo.Productoes");
            DropForeignKey("dbo.DetalleEventoes", "EventID", "dbo.Events");
            DropForeignKey("dbo.Pedidoes", "LocalidadID", "dbo.Localidads");
            DropForeignKey("dbo.DetallePedidoes", "PedidoID", "dbo.Pedidoes");
            DropIndex("dbo.DetalleEventoes", new[] { "EventID" });
            DropIndex("dbo.DetalleEventoes", new[] { "ProductoID" });
            DropIndex("dbo.Pedidoes", new[] { "LocalidadID" });
            DropIndex("dbo.DetallePedidoes", new[] { "ProductoID" });
            DropIndex("dbo.DetallePedidoes", new[] { "PedidoID" });
            DropTable("dbo.Events");
            DropTable("dbo.DetalleEventoes");
            DropTable("dbo.Productoes");
            DropTable("dbo.Localidads");
            DropTable("dbo.Pedidoes");
            DropTable("dbo.DetallePedidoes");
        }
    }
}
