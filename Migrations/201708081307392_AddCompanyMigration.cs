namespace Banking.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCompanyMigration : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.AccountEntities", "UserId", "dbo.UserEntities");
            DropForeignKey("dbo.CreditEntities", "UserId", "dbo.UserEntities");
            DropForeignKey("dbo.DepositEntities", "UserId", "dbo.UserEntities");
            DropIndex("dbo.AccountEntities", new[] { "UserId" });
            DropIndex("dbo.CreditEntities", new[] { "UserId" });
            DropIndex("dbo.DepositEntities", new[] { "UserId" });
            AlterColumn("dbo.AccountEntities", "UserId", c => c.Int(nullable: false));
            AlterColumn("dbo.CreditEntities", "UserId", c => c.Int(nullable: false));
            AlterColumn("dbo.DepositEntities", "UserId", c => c.Int(nullable: false));
            CreateIndex("dbo.AccountEntities", "UserId");
            CreateIndex("dbo.CreditEntities", "UserId");
            CreateIndex("dbo.DepositEntities", "UserId");
            AddForeignKey("dbo.AccountEntities", "UserId", "dbo.UserEntities", "Id", cascadeDelete: true);
            AddForeignKey("dbo.CreditEntities", "UserId", "dbo.UserEntities", "Id", cascadeDelete: true);
            AddForeignKey("dbo.DepositEntities", "UserId", "dbo.UserEntities", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.DepositEntities", "UserId", "dbo.UserEntities");
            DropForeignKey("dbo.CreditEntities", "UserId", "dbo.UserEntities");
            DropForeignKey("dbo.AccountEntities", "UserId", "dbo.UserEntities");
            DropIndex("dbo.DepositEntities", new[] { "UserId" });
            DropIndex("dbo.CreditEntities", new[] { "UserId" });
            DropIndex("dbo.AccountEntities", new[] { "UserId" });
            AlterColumn("dbo.DepositEntities", "UserId", c => c.Int());
            AlterColumn("dbo.CreditEntities", "UserId", c => c.Int());
            AlterColumn("dbo.AccountEntities", "UserId", c => c.Int());
            CreateIndex("dbo.DepositEntities", "UserId");
            CreateIndex("dbo.CreditEntities", "UserId");
            CreateIndex("dbo.AccountEntities", "UserId");
            AddForeignKey("dbo.DepositEntities", "UserId", "dbo.UserEntities", "Id");
            AddForeignKey("dbo.CreditEntities", "UserId", "dbo.UserEntities", "Id");
            AddForeignKey("dbo.AccountEntities", "UserId", "dbo.UserEntities", "Id");
        }
    }
}
