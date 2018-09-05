namespace CharacterManager.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedNullableInts : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Character", "Religion", c => c.Int());
            AlterColumn("dbo.Character", "ArmorClass", c => c.Int());
            AlterColumn("dbo.Character", "Initiative", c => c.Int());
            AlterColumn("dbo.Character", "Speed", c => c.Int());
            AlterColumn("dbo.Character", "SavingStr", c => c.Int());
            AlterColumn("dbo.Character", "SavingDex", c => c.Int());
            AlterColumn("dbo.Character", "SavingCon", c => c.Int());
            AlterColumn("dbo.Character", "SavingInt", c => c.Int());
            AlterColumn("dbo.Character", "SavingWis", c => c.Int());
            AlterColumn("dbo.Character", "SavingCha", c => c.Int());
            AlterColumn("dbo.Character", "Acrobatics", c => c.Int());
            AlterColumn("dbo.Character", "AnimalHandling", c => c.Int());
            AlterColumn("dbo.Character", "Arcana", c => c.Int());
            AlterColumn("dbo.Character", "Athletics", c => c.Int());
            AlterColumn("dbo.Character", "Deception", c => c.Int());
            AlterColumn("dbo.Character", "History", c => c.Int());
            AlterColumn("dbo.Character", "Insight", c => c.Int());
            AlterColumn("dbo.Character", "Intimidation", c => c.Int());
            AlterColumn("dbo.Character", "Investigation", c => c.Int());
            AlterColumn("dbo.Character", "Medicine", c => c.Int());
            AlterColumn("dbo.Character", "Nature", c => c.Int());
            AlterColumn("dbo.Character", "Perception", c => c.Int());
            AlterColumn("dbo.Character", "Performance", c => c.Int());
            AlterColumn("dbo.Character", "Persuasion", c => c.Int());
            AlterColumn("dbo.Character", "SleightOfHand", c => c.Int());
            AlterColumn("dbo.Character", "Stealth", c => c.Int());
            AlterColumn("dbo.Character", "Survival", c => c.Int());
            DropColumn("dbo.Character", "Regligion");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Character", "Regligion", c => c.Int(nullable: false));
            AlterColumn("dbo.Character", "Survival", c => c.Int(nullable: false));
            AlterColumn("dbo.Character", "Stealth", c => c.Int(nullable: false));
            AlterColumn("dbo.Character", "SleightOfHand", c => c.Int(nullable: false));
            AlterColumn("dbo.Character", "Persuasion", c => c.Int(nullable: false));
            AlterColumn("dbo.Character", "Performance", c => c.Int(nullable: false));
            AlterColumn("dbo.Character", "Perception", c => c.Int(nullable: false));
            AlterColumn("dbo.Character", "Nature", c => c.Int(nullable: false));
            AlterColumn("dbo.Character", "Medicine", c => c.Int(nullable: false));
            AlterColumn("dbo.Character", "Investigation", c => c.Int(nullable: false));
            AlterColumn("dbo.Character", "Intimidation", c => c.Int(nullable: false));
            AlterColumn("dbo.Character", "Insight", c => c.Int(nullable: false));
            AlterColumn("dbo.Character", "History", c => c.Int(nullable: false));
            AlterColumn("dbo.Character", "Deception", c => c.Int(nullable: false));
            AlterColumn("dbo.Character", "Athletics", c => c.Int(nullable: false));
            AlterColumn("dbo.Character", "Arcana", c => c.Int(nullable: false));
            AlterColumn("dbo.Character", "AnimalHandling", c => c.Int(nullable: false));
            AlterColumn("dbo.Character", "Acrobatics", c => c.Int(nullable: false));
            AlterColumn("dbo.Character", "SavingCha", c => c.Int(nullable: false));
            AlterColumn("dbo.Character", "SavingWis", c => c.Int(nullable: false));
            AlterColumn("dbo.Character", "SavingInt", c => c.Int(nullable: false));
            AlterColumn("dbo.Character", "SavingCon", c => c.Int(nullable: false));
            AlterColumn("dbo.Character", "SavingDex", c => c.Int(nullable: false));
            AlterColumn("dbo.Character", "SavingStr", c => c.Int(nullable: false));
            AlterColumn("dbo.Character", "Speed", c => c.Int(nullable: false));
            AlterColumn("dbo.Character", "Initiative", c => c.Int(nullable: false));
            AlterColumn("dbo.Character", "ArmorClass", c => c.Int(nullable: false));
            DropColumn("dbo.Character", "Religion");
        }
    }
}
