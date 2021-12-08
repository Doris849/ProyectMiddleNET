namespace TecGurusMiddleMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migracion2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Teachers",
                c => new
                    {
                        TeacherId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Cedula = c.Int(nullable: false),
                        Grupo = c.String(),
                    })
                .PrimaryKey(t => t.TeacherId);
            
            AddColumn("dbo.Students", "Email", c => c.String());
            DropColumn("dbo.Students", "MyProperty");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Students", "MyProperty", c => c.Int(nullable: false));
            DropColumn("dbo.Students", "Email");
            DropTable("dbo.Teachers");
        }
    }
}
