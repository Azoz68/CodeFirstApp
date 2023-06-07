namespace CodeFirstApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class firstMigrataion : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Items",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        ProductName = c.String(),
                        P_Price = c.String(),
                        P_Desc = c.String(),
                        C_id_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.TypeCategories", t => t.C_id_id)
                .Index(t => t.C_id_id);
            
            CreateTable(
                "dbo.TypeCategories",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        TypeName = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Items", "C_id_id", "dbo.TypeCategories");
            DropIndex("dbo.Items", new[] { "C_id_id" });
            DropTable("dbo.TypeCategories");
            DropTable("dbo.Items");
        }
    }
}
