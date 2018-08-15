namespace CharacterManager.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedDbSets : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Inventory",
                c => new
                    {
                        InventoryId = c.Int(nullable: false, identity: true),
                        CharacterId = c.Int(nullable: false),
                        ItemName = c.String(nullable: false),
                        ItemQuantity = c.Int(nullable: false),
                        ItemType = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.InventoryId)
                .ForeignKey("dbo.Character", t => t.CharacterId, cascadeDelete: true)
                .Index(t => t.CharacterId);
            
            CreateTable(
                "dbo.Journal",
                c => new
                    {
                        JournalId = c.Int(nullable: false, identity: true),
                        CharacterId = c.Int(nullable: false),
                        Title = c.String(nullable: false),
                        Content = c.String(nullable: false),
                        CreatedUtc = c.DateTimeOffset(nullable: false, precision: 7),
                        ModifiedUtc = c.DateTimeOffset(precision: 7),
                    })
                .PrimaryKey(t => t.JournalId)
                .ForeignKey("dbo.Character", t => t.CharacterId, cascadeDelete: true)
                .Index(t => t.CharacterId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Journal", "CharacterId", "dbo.Character");
            DropForeignKey("dbo.Inventory", "CharacterId", "dbo.Character");
            DropIndex("dbo.Journal", new[] { "CharacterId" });
            DropIndex("dbo.Inventory", new[] { "CharacterId" });
            DropTable("dbo.Journal");
            DropTable("dbo.Inventory");
        }
    }
}
