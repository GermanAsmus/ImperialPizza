namespace PizzaMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migration1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Recetas",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Detalles",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Cantidad = c.Int(nullable: false),
                        Unidad = c.String(),
                        Ingrediente_ID = c.Int(),
                        Receta_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Ingredientes", t => t.Ingrediente_ID)
                .ForeignKey("dbo.Recetas", t => t.Receta_ID)
                .Index(t => t.Ingrediente_ID)
                .Index(t => t.Receta_ID);
            
            CreateTable(
                "dbo.Ingredientes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            AddColumn("dbo.Pizzas", "Receta_ID", c => c.Int());
            CreateIndex("dbo.Pizzas", "Receta_ID");
            AddForeignKey("dbo.Pizzas", "Receta_ID", "dbo.Recetas", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Pizzas", "Receta_ID", "dbo.Recetas");
            DropForeignKey("dbo.Detalles", "Receta_ID", "dbo.Recetas");
            DropForeignKey("dbo.Detalles", "Ingrediente_ID", "dbo.Ingredientes");
            DropIndex("dbo.Detalles", new[] { "Receta_ID" });
            DropIndex("dbo.Detalles", new[] { "Ingrediente_ID" });
            DropIndex("dbo.Pizzas", new[] { "Receta_ID" });
            DropColumn("dbo.Pizzas", "Receta_ID");
            DropTable("dbo.Ingredientes");
            DropTable("dbo.Detalles");
            DropTable("dbo.Recetas");
        }
    }
}
