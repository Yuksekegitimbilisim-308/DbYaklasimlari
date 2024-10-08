namespace CodeFirstEfProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedGlassCount : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Cars", "GlassCount", c => c.Int());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Cars", "GlassCount");
        }
    }
}
