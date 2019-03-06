namespace Interface.Service.Services.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.T_SYS_USER",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        WorkerId = c.String(nullable: false, maxLength: 50, unicode: false, storeType: "nvarchar"),
                        UserName = c.String(nullable: false, maxLength: 50, unicode: false, storeType: "nvarchar"),
                        Password = c.String(nullable: false, maxLength: 50, unicode: false, storeType: "nvarchar"),
                        OldPassword = c.String(maxLength: 50, unicode: false, storeType: "nvarchar"),
                        prefix_eng = c.String(unicode: false),
                        f_name_eng = c.String(unicode: false),
                        l_name_eng = c.String(unicode: false),
                        Picture = c.String(maxLength: 200, unicode: false, storeType: "nvarchar"),
                        MobilePhone = c.String(maxLength: 50, unicode: false, storeType: "nvarchar"),
                        Email = c.String(maxLength: 50, unicode: false, storeType: "nvarchar"),
                        Enabled = c.Boolean(nullable: false),
                        Remark = c.String(maxLength: 200, unicode: false, storeType: "nvarchar"),
                        CreatedDate = c.DateTime(nullable: false, precision: 0),
                        UpdatedDate = c.DateTime(nullable: false, precision: 0),
                        ProjectId = c.Guid(nullable: false),
                        EnterpriseId = c.Guid(nullable: false),
                        UserId = c.Guid(),
                        UpdatedUserId = c.Guid(),
                        Deleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.T_SYS_USER");
        }
    }
}
