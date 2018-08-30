namespace CharacterManager.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedSkills : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Character", "Acrobatics", c => c.Int(nullable: false));
            AddColumn("dbo.Character", "Arcana", c => c.Int(nullable: false));
            AddColumn("dbo.Character", "Athletics", c => c.Int(nullable: false));
            AddColumn("dbo.Character", "Deception", c => c.Int(nullable: false));
            AddColumn("dbo.Character", "History", c => c.Int(nullable: false));
            AddColumn("dbo.Character", "Insight", c => c.Int(nullable: false));
            AddColumn("dbo.Character", "Intimidation", c => c.Int(nullable: false));
            AddColumn("dbo.Character", "Investigation", c => c.Int(nullable: false));
            AddColumn("dbo.Character", "Medicine", c => c.Int(nullable: false));
            AddColumn("dbo.Character", "Nature", c => c.Int(nullable: false));
            AddColumn("dbo.Character", "Perception", c => c.Int(nullable: false));
            AddColumn("dbo.Character", "Performance", c => c.Int(nullable: false));
            AddColumn("dbo.Character", "Persuasion", c => c.Int(nullable: false));
            AddColumn("dbo.Character", "Regligion", c => c.Int(nullable: false));
            AddColumn("dbo.Character", "SleightOfHand", c => c.Int(nullable: false));
            AddColumn("dbo.Character", "Stealth", c => c.Int(nullable: false));
            AddColumn("dbo.Character", "Survival", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Character", "Survival");
            DropColumn("dbo.Character", "Stealth");
            DropColumn("dbo.Character", "SleightOfHand");
            DropColumn("dbo.Character", "Regligion");
            DropColumn("dbo.Character", "Persuasion");
            DropColumn("dbo.Character", "Performance");
            DropColumn("dbo.Character", "Perception");
            DropColumn("dbo.Character", "Nature");
            DropColumn("dbo.Character", "Medicine");
            DropColumn("dbo.Character", "Investigation");
            DropColumn("dbo.Character", "Intimidation");
            DropColumn("dbo.Character", "Insight");
            DropColumn("dbo.Character", "History");
            DropColumn("dbo.Character", "Deception");
            DropColumn("dbo.Character", "Athletics");
            DropColumn("dbo.Character", "Arcana");
            DropColumn("dbo.Character", "Acrobatics");
        }
    }
}
