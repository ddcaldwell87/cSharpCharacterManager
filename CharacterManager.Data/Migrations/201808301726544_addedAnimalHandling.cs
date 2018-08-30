namespace CharacterManager.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedAnimalHandling : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Character", "AnimalHandling", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Character", "AnimalHandling");
        }
    }
}
