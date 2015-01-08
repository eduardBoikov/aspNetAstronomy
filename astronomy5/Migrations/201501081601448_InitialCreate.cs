namespace astronomy5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Lidaparatis",
                c => new
                    {
                        LidID = c.Int(nullable: false, identity: true),
                        Nosaukums = c.String(),
                        Apraksts = c.String(),
                    })
                .PrimaryKey(t => t.LidID);
            
            CreateTable(
                "dbo.Misijas",
                c => new
                    {
                        MisijaID = c.Int(nullable: false, identity: true),
                        Nosaukums = c.String(),
                        Datums = c.DateTime(),
                        Organizacija = c.String(),
                        Apraksts = c.String(),
                        Rezultats = c.String(),
                        Tips = c.Int(),
                        RefTips_RefTipsID = c.Int(),
                    })
                .PrimaryKey(t => t.MisijaID)
                .ForeignKey("dbo.RefTips", t => t.RefTips_RefTipsID)
                .Index(t => t.RefTips_RefTipsID);
            
            CreateTable(
                "dbo.RefTips",
                c => new
                    {
                        RefTipsID = c.Int(nullable: false, identity: true),
                        Veids = c.String(),
                    })
                .PrimaryKey(t => t.RefTipsID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Misijas", "RefTips_RefTipsID", "dbo.RefTips");
            DropIndex("dbo.Misijas", new[] { "RefTips_RefTipsID" });
            DropTable("dbo.RefTips");
            DropTable("dbo.Misijas");
            DropTable("dbo.Lidaparatis");
        }
    }
}
