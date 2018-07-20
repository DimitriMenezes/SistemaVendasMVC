namespace SistemaVendas.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ItemVenda",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Quantidade = c.Int(nullable: false),
                        ProdutoId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Produto", t => t.ProdutoId, cascadeDelete: true)
                .Index(t => t.ProdutoId);
            
            CreateTable(
                "dbo.Produto",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descricao = c.String(),
                        Preço = c.Double(nullable: false),
                        Estoque = c.Int(nullable: false),
                        DataFabricacao = c.DateTime(nullable: false),
                        Valido = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Venda",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DataVenda = c.DateTime(nullable: false),
                        ValorTotal = c.Single(nullable: false),
                        ItemVendaId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ItemVenda", t => t.ItemVendaId, cascadeDelete: true)
                .Index(t => t.ItemVendaId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Venda", "ItemVendaId", "dbo.ItemVenda");
            DropForeignKey("dbo.ItemVenda", "ProdutoId", "dbo.Produto");
            DropIndex("dbo.Venda", new[] { "ItemVendaId" });
            DropIndex("dbo.ItemVenda", new[] { "ProdutoId" });
            DropTable("dbo.Venda");
            DropTable("dbo.Produto");
            DropTable("dbo.ItemVenda");
        }
    }
}
