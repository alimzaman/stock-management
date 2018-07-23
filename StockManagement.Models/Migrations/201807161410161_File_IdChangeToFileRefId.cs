namespace StockManagement.Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class File_IdChangeToFileRefId : DbMigration
    {
        public override void Up()
        {
           
            DropPrimaryKey("dbo.Files");
            AddColumn("dbo.Files", "Id", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.Files", "FileRefId", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.Files", "Id");
            DropColumn("dbo.Files", "FileId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Files", "FileId", c => c.Int(nullable: false, identity: true));
            DropPrimaryKey("dbo.Files");
            DropColumn("dbo.Files", "FileRefId");
            DropColumn("dbo.Files", "Id");
            AddPrimaryKey("dbo.Files", "FileId");
        }
    }
}
