namespace StockManagement.Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class File_Party_Migration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Files",
                c => new
                    {
                        FileId = c.Int(nullable: false, identity: true),
                        FileName = c.String(),
                        FileType = c.String(),
                        ProductId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.FileId)
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .Index(t => t.ProductId);
            
            AddColumn("dbo.Employees", "IsDeleted", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Files", "ProductId", "dbo.Products");
            DropIndex("dbo.Files", new[] { "ProductId" });
            DropColumn("dbo.Employees", "IsDeleted");
            DropTable("dbo.Files");
        }
    }
}
