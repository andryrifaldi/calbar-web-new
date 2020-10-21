namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddConvictionTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SCCLSFP",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CLSYAR = c.Int(nullable: false),
                        CLSOS = c.Int(name: "CLSOS#", nullable: false),
                        CLLIN = c.Int(name: "CLLIN#", nullable: false),
                        CLVIOCD = c.String(),
                        CLFLMSD = c.String(),
                        CLJURIS = c.String(),
                        CLTITLE = c.String(),
                        CLKYWRD = c.String(),
                        CLCBCONF = c.Boolean(nullable: false),
                        CLCLSCD = c.String(),
                        CLCLSYR = c.Int(nullable: false),
                        CLCSNAM = c.String(),
                        CLDCNBR = c.String(),
                        CLOLNBR = c.String(),
                        CLOLLN = c.Int(name: "CLOLLN#", nullable: false),
                        CLCMNT80 = c.String(),
                        CLLOG = c.Int(name: "CL@LOG", nullable: false),
                        CLLOGTM = c.Int(nullable: false),
                        CLLOGID = c.String(),
                        CLLOGXD = c.String(),
                        CLLOGFP = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.SCCLSFP");
        }
    }
}
