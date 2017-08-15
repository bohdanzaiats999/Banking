namespace Banking.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCompanyMigration1 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.AccountEntities", newName: "Account");
            RenameTable(name: "dbo.UserEntities", newName: "User");
            RenameTable(name: "dbo.CreditEntities", newName: "Credit");
            RenameTable(name: "dbo.DepositEntities", newName: "Deposit");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Deposit", newName: "DepositEntities");
            RenameTable(name: "dbo.Credit", newName: "CreditEntities");
            RenameTable(name: "dbo.User", newName: "UserEntities");
            RenameTable(name: "dbo.Account", newName: "AccountEntities");
        }
    }
}
