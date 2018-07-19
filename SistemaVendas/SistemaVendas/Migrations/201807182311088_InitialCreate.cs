namespace SistemaVendas.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Estoque",
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
                        ID = c.Int(nullable: false, identity: true),
                        Descricao = c.String(),
                        DataFabricacao = c.DateTime(nullable: false),
                        Preço = c.Double(nullable: false),
                        Disponivel = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Venda",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descricao = c.String(),
                        DataFabricacao = c.DateTime(nullable: false),
                        Preço = c.Single(nullable: false),
                        ProdutoId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Produto", t => t.ProdutoId, cascadeDelete: true)
                .Index(t => t.ProdutoId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Estoque", "ProdutoId", "dbo.Produto");
            DropForeignKey("dbo.Venda", "ProdutoId", "dbo.Produto");
            DropIndex("dbo.Venda", new[] { "ProdutoId" });
            DropIndex("dbo.Estoque", new[] { "ProdutoId" });
            DropTable("dbo.Venda");
            DropTable("dbo.Produto");
            DropTable("dbo.Estoque");
        }
    }
}
