namespace CharacterManager.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedInventoryOwnerId : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Inventory", "OwnerId", c => c.Guid(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Inventory", "OwnerId");
        }
    }
}
