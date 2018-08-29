namespace CharacterManager.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedAttributes : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Character", "Strength", c => c.Int(nullable: false));
            AddColumn("dbo.Character", "Dexterity", c => c.Int(nullable: false));
            AddColumn("dbo.Character", "Constitution", c => c.Int(nullable: false));
            AddColumn("dbo.Character", "Intelligence", c => c.Int(nullable: false));
            AddColumn("dbo.Character", "Wisdom", c => c.Int(nullable: false));
            AddColumn("dbo.Character", "Charisma", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Character", "Charisma");
            DropColumn("dbo.Character", "Wisdom");
            DropColumn("dbo.Character", "Intelligence");
            DropColumn("dbo.Character", "Constitution");
            DropColumn("dbo.Character", "Dexterity");
            DropColumn("dbo.Character", "Strength");
        }
    }
}
