namespace Banking.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DBMigration : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Accounts", "Money", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.Credits", "Money", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.Credits", "InterestRate", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.Credits", "MonthlyPayment", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.Credits", "LastDateAccrued", c => c.DateTimeOffset(nullable: false, precision: 7));
            AlterColumn("dbo.Deposits", "Money", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.Deposits", "InterestRate", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.Deposits", "LastDateAccrued", c => c.DateTimeOffset(nullable: false, precision: 7));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Deposits", "LastDateAccrued", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Deposits", "InterestRate", c => c.Single(nullable: false));
            AlterColumn("dbo.Deposits", "Money", c => c.Single(nullable: false));
            AlterColumn("dbo.Credits", "LastDateAccrued", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Credits", "MonthlyPayment", c => c.Single(nullable: false));
            AlterColumn("dbo.Credits", "InterestRate", c => c.Single(nullable: false));
            AlterColumn("dbo.Credits", "Money", c => c.Single(nullable: false));
            AlterColumn("dbo.Accounts", "Money", c => c.Single(nullable: false));
        }
    }
}
