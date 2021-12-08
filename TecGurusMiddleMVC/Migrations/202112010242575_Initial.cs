namespace TecGurusMiddleMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Students",
                // codigo Lambda. Fluent API. Codigo entendible transaccional
                c => new
                    {
                        StudentId = c.Int(nullable: false, identity: true),
                        Age = c.Int(nullable: false),
                        Name = c.String(nullable: false, maxLength: 50),
                        MyProperty = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.StudentId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Students");
        }
    }
}
