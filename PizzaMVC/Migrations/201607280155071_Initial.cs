namespace PizzaMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
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
            
            CreateTable(
                "dbo.LineaEventoes",
                c => new
                    {
                        LineaEventoID = c.Int(nullable: false, identity: true),
                        EventID = c.Int(nullable: false),
                        PizzaID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.LineaEventoID)
                .ForeignKey("dbo.Events", t => t.EventID, cascadeDelete: true)
                .ForeignKey("dbo.Pizzas", t => t.PizzaID, cascadeDelete: true)
                .Index(t => t.EventID)
                .Index(t => t.PizzaID);
            
            CreateTable(
                "dbo.Pizzas",
                c => new
                    {
                        PizzaID = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 80),
                        Descripcion = c.String(nullable: false, maxLength: 200),
                        Precio = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Receta = c.String(nullable: false, maxLength: 800),
                    })
                .PrimaryKey(t => t.PizzaID);
            
            CreateTable(
                "dbo.LineaPedidoes",
                c => new
                    {
                        LineaPedidoID = c.Int(nullable: false, identity: true),
                        PedidoID = c.Int(nullable: false),
                        PizzaID = c.Int(nullable: false),
                        Cantidad = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.LineaPedidoID)
                .ForeignKey("dbo.Pedidoes", t => t.PedidoID, cascadeDelete: true)
                .ForeignKey("dbo.Pizzas", t => t.PizzaID, cascadeDelete: true)
                .Index(t => t.PedidoID)
                .Index(t => t.PizzaID);
            
            CreateTable(
                "dbo.Pedidoes",
                c => new
                    {
                        PedidoID = c.Int(nullable: false, identity: true),
                        Cliente = c.String(),
                        Direccion = c.String(),
                        Fecha = c.DateTime(nullable: false),
                        Hora = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.PedidoID);
            
            CreateTable(
                "dbo.AspNetRoles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true, name: "RoleNameIndex");
            
            CreateTable(
                "dbo.AspNetUserRoles",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        RoleId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.UserId, t.RoleId })
                .ForeignKey("dbo.AspNetRoles", t => t.RoleId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.AspNetUsers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Email = c.String(maxLength: 256),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.UserName, unique: true, name: "UserNameIndex");
            
            CreateTable(
                "dbo.AspNetUserClaims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(nullable: false, maxLength: 128),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUserLogins",
                c => new
                    {
                        LoginProvider = c.String(nullable: false, maxLength: 128),
                        ProviderKey = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.LoginProvider, t.ProviderKey, t.UserId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropForeignKey("dbo.LineaPedidoes", "PizzaID", "dbo.Pizzas");
            DropForeignKey("dbo.LineaPedidoes", "PedidoID", "dbo.Pedidoes");
            DropForeignKey("dbo.LineaEventoes", "PizzaID", "dbo.Pizzas");
            DropForeignKey("dbo.LineaEventoes", "EventID", "dbo.Events");
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            DropIndex("dbo.AspNetUserClaims", new[] { "UserId" });
            DropIndex("dbo.AspNetUsers", "UserNameIndex");
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.AspNetRoles", "RoleNameIndex");
            DropIndex("dbo.LineaPedidoes", new[] { "PizzaID" });
            DropIndex("dbo.LineaPedidoes", new[] { "PedidoID" });
            DropIndex("dbo.LineaEventoes", new[] { "PizzaID" });
            DropIndex("dbo.LineaEventoes", new[] { "EventID" });
            DropTable("dbo.AspNetUserLogins");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.AspNetUsers");
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.AspNetRoles");
            DropTable("dbo.Pedidoes");
            DropTable("dbo.LineaPedidoes");
            DropTable("dbo.Pizzas");
            DropTable("dbo.LineaEventoes");
            DropTable("dbo.Events");
        }
    }
}
