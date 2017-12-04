namespace Cimri.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class stockIdEdit : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.ProductTransactions", name: "Product_StockId", newName: "StockId");
            RenameIndex(table: "dbo.ProductTransactions", name: "IX_Product_StockId", newName: "IX_StockId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.ProductTransactions", name: "IX_StockId", newName: "IX_Product_StockId");
            RenameColumn(table: "dbo.ProductTransactions", name: "StockId", newName: "Product_StockId");
        }
    }
}
