namespace CharacterManager.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedPropertiesToCharacter : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Character", "Alignment", c => c.Int(nullable: false));
            AddColumn("dbo.Character", "HitPoints", c => c.Int(nullable: false));
            AddColumn("dbo.Character", "PersonalityTraits", c => c.String());
            AddColumn("dbo.Character", "Ideals", c => c.String());
            AddColumn("dbo.Character", "Bonds", c => c.String());
            AddColumn("dbo.Character", "Flaws", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Character", "Flaws");
            DropColumn("dbo.Character", "Bonds");
            DropColumn("dbo.Character", "Ideals");
            DropColumn("dbo.Character", "PersonalityTraits");
            DropColumn("dbo.Character", "HitPoints");
            DropColumn("dbo.Character", "Alignment");
        }
    }
}
