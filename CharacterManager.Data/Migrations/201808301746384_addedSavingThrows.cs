namespace CharacterManager.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedSavingThrows : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Character", "ArmorClass", c => c.Int(nullable: false));
            AddColumn("dbo.Character", "Initiative", c => c.Int(nullable: false));
            AddColumn("dbo.Character", "Speed", c => c.Int(nullable: false));
            AddColumn("dbo.Character", "HitDie", c => c.String());
            AddColumn("dbo.Character", "SavingStr", c => c.Int(nullable: false));
            AddColumn("dbo.Character", "SavingDex", c => c.Int(nullable: false));
            AddColumn("dbo.Character", "SavingCon", c => c.Int(nullable: false));
            AddColumn("dbo.Character", "SavingInt", c => c.Int(nullable: false));
            AddColumn("dbo.Character", "SavingWis", c => c.Int(nullable: false));
            AddColumn("dbo.Character", "SavingCha", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Character", "SavingCha");
            DropColumn("dbo.Character", "SavingWis");
            DropColumn("dbo.Character", "SavingInt");
            DropColumn("dbo.Character", "SavingCon");
            DropColumn("dbo.Character", "SavingDex");
            DropColumn("dbo.Character", "SavingStr");
            DropColumn("dbo.Character", "HitDie");
            DropColumn("dbo.Character", "Speed");
            DropColumn("dbo.Character", "Initiative");
            DropColumn("dbo.Character", "ArmorClass");
        }
    }
}
