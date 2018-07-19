namespace SistemaVendas.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ColumnNamesChanged : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Venda", "DataVenda", c => c.DateTime(nullable: false));
            AddColumn("dbo.Venda", "ValorTotal", c => c.Single(nullable: false));
            DropColumn("dbo.Venda", "DataFabricacao");
            DropColumn("dbo.Venda", "Preço");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Venda", "Preço", c => c.Single(nullable: false));
            AddColumn("dbo.Venda", "DataFabricacao", c => c.DateTime(nullable: false));
            DropColumn("dbo.Venda", "ValorTotal");
            DropColumn("dbo.Venda", "DataVenda");
        }
    }
}
