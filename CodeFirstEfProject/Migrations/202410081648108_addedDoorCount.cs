namespace CodeFirstEfProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedDoorCount : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Cars", "DoorCount", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Cars", "DoorCount");
        }
    }
}
