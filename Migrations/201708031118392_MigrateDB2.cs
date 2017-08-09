namespace Banking.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MigrateDB2 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.CreditAccounts", newName: "CreditEntities");
            RenameTable(name: "dbo.CurrentAccounts", newName: "AccountEntities");
            RenameTable(name: "dbo.DepositAccounts", newName: "DepositEntities");
            CreateTable(
                "dbo.UserEntities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Login = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            DropTable("dbo.Users");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Login = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            DropTable("dbo.UserEntities");
            RenameTable(name: "dbo.DepositEntities", newName: "DepositAccounts");
            RenameTable(name: "dbo.AccountEntities", newName: "CurrentAccounts");
            RenameTable(name: "dbo.CreditEntities", newName: "CreditAccounts");
        }
    }
}
