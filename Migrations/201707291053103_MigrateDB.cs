namespace Banking.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MigrateDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CurrentAccounts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Number = c.String(),
                        Money = c.Single(nullable: false),
                        UserId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.UserId)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Login = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.DepositCreditAccounts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Number = c.String(),
                        AccountType = c.Int(nullable: false),
                        Money = c.Single(nullable: false),
                        InterestRate = c.Single(nullable: false),
                        LastDateAccrued = c.DateTime(nullable: false),
                        UserId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.UserId)
                .Index(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.DepositCreditAccounts", "UserId", "dbo.Users");
            DropForeignKey("dbo.CurrentAccounts", "UserId", "dbo.Users");
            DropIndex("dbo.DepositCreditAccounts", new[] { "UserId" });
            DropIndex("dbo.CurrentAccounts", new[] { "UserId" });
            DropTable("dbo.DepositCreditAccounts");
            DropTable("dbo.Users");
            DropTable("dbo.CurrentAccounts");
        }
    }
}
