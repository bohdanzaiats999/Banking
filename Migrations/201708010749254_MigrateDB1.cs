namespace Banking.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MigrateDB1 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.DepositCreditAccounts", newName: "CreditAccounts");
            CreateTable(
                "dbo.DepositAccounts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Number = c.String(),
                        Money = c.Single(nullable: false),
                        InterestRate = c.Single(nullable: false),
                        LastDateAccrued = c.DateTime(nullable: false),
                        UserId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.UserId);
            
            AddColumn("dbo.CreditAccounts", "MonthlyPayment", c => c.Single(nullable: false));
            AddColumn("dbo.CreditAccounts", "AvailabilityCollateral", c => c.Boolean(nullable: false));
            DropColumn("dbo.CreditAccounts", "AccountType");
        }
        
        public override void Down()
        {
            AddColumn("dbo.CreditAccounts", "AccountType", c => c.Int(nullable: false));
            DropIndex("dbo.DepositAccounts", new[] { "UserId" });
            DropColumn("dbo.CreditAccounts", "AvailabilityCollateral");
            DropColumn("dbo.CreditAccounts", "MonthlyPayment");
            DropTable("dbo.DepositAccounts");
            RenameTable(name: "dbo.CreditAccounts", newName: "DepositCreditAccounts");
        }
    }
}
