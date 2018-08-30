namespace CharacterManager.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedLevelProperty : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Character", "Level", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Character", "Level");
        }
    }
}
