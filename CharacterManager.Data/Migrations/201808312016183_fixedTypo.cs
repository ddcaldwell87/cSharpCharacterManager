namespace CharacterManager.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fixedTypo : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Character", "Religion", c => c.Int(nullable: false));
            DropColumn("dbo.Character", "Religion");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Character", "Religion", c => c.Int(nullable: false));
            DropColumn("dbo.Character", "Religion");
        }
    }
}
