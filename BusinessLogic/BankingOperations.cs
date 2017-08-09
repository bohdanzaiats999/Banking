using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Security.Authentication;
using Banking.Entity;
using System.Windows.Forms;
using Banking.DAL;
using System.Security.Cryptography;
using Banking.Model;

namespace Banking.BusinessLogic
{
    public class BankingOperations
    {
        private readonly UnitOfWork db;
        private int userId;

        public BankingOperations()
        {
            db = new UnitOfWork();
        }

        // Log In
        public void LogIn(string login, string password)
        {
            if (login != "" && password != "")
            {
                var user = db.Repository<UserEntity>().GetByLogin(login);
                if (user != null)
                {
                    AesCrypt aes = new AesCrypt();
                    string cryptedPassword = aes.EncryptAes(password);

                    if (cryptedPassword == user.Password)
                    {
                        this.userId = user.Id;
                        return;
                    }
                }
            }
            throw new AuthenticationException("Login or Password is wrong");
        }

        // Registration
        public void Registration(string login, string password)
        {

            if (login != "" & password != "")
            {
                var user = db.Repository<UserEntity>().GetByLogin(login);

                if (user == null)
                {
                    AesCrypt aes = new AesCrypt();
                    string encryptedPassword = aes.EncryptAes(password);

                    var entityToInsert = new AccountEntity
                    {
                        User = new UserEntity { Login = login, Password = encryptedPassword },
                        Money = 0
                    };
                    db.Repository<AccountEntity>().Insert(entityToInsert);
                    db.SaveChanges();
                    entityToInsert.Number = GenerateAccountNumber(entityToInsert.UserId, entityToInsert.Id, AccountType.Account);
                    db.Repository<AccountEntity>().Update(entityToInsert);
                    db.SaveChanges();

                    this.userId = entityToInsert.UserId;
                    return;
                }
        }
            throw new AuthenticationException("User alredy exist");
        }

        public void FillCurrentAccountComboBox(ComboBox comboBox)
        {
            comboBox.DataSource = db.Repository<AccountEntity>().GetCurrentAccountsListById(userId);
            comboBox.DisplayMember = "Number";
        }

        public void FillDepositAccountComboBox(ComboBox comboBox)
        {
            comboBox.DataSource = db.Repository<DepositEntity>().GetDepositAccountsListById(userId);
            comboBox.DisplayMember = "Number";
        }

        public void FillCreditAccountComboBox(ComboBox comboBox)
        {
            comboBox.DataSource = db.Repository<CreditEntity>().GetCreditAccountsListById(userId);
            comboBox.DisplayMember = "Number";
        }

        public void AddAccount()
        {
            var entityToInsert = new AccountEntity
            {
                UserId = userId,
                Money = 0
            };
            db.Repository<AccountEntity>().Insert(entityToInsert);
            db.SaveChanges();
            entityToInsert.Number = GenerateAccountNumber(entityToInsert.UserId, entityToInsert.Id, AccountType.Account);
            db.Repository<AccountEntity>().Update(entityToInsert);
            db.SaveChanges();
        }

        public void AddDeposit(string interestRate,string money)
        {
            if (money != "")
            {
            var entityToInsert = new DepositEntity
            {
                UserId = userId,
                Money = float.Parse(money),
                InterestRate = float.Parse(interestRate),
                LastDateAccrued = DateTime.Now
            };
            db.Repository<DepositEntity>().Insert(entityToInsert);
            db.SaveChanges();
            entityToInsert.Number = GenerateAccountNumber(entityToInsert.UserId, entityToInsert.Id, AccountType.Deposit);
            db.Repository<DepositEntity>().Update(entityToInsert);
            db.SaveChanges();
            }
            else
            {
                throw new AuthenticationException("Line 'Money' is not filled");
            }
        }

        public void AddCredit(string interestRate, string monthlyPayment, bool availabilityCollateral, string money)
        {
            if (money != "" && monthlyPayment != "")
            {
                var entityToInsert = new CreditEntity
                {
                    UserId = userId,
                    Money = float.Parse(money),
                    InterestRate = float.Parse(interestRate),
                    LastDateAccrued = DateTime.Now,
                    MonthlyPayment = float.Parse(monthlyPayment),
                    AvailabilityCollateral = availabilityCollateral
                };
                db.Repository<CreditEntity>().Insert(entityToInsert);
                db.SaveChanges();
                entityToInsert.Number = GenerateAccountNumber(entityToInsert.UserId, entityToInsert.Id, AccountType.Credit);
                db.Repository<CreditEntity>().Update(entityToInsert);
                db.SaveChanges(); 
            }
            else
            {
                throw new AuthenticationException(" All Lines is not filled");
            }
        }

        // Generate Account Number
        private string GenerateAccountNumber(int userId, int accountId, AccountType accountType)
        {
            string accountNumber = string.Empty;
            int typeNumber = (int)accountType;
            string strAccountType = typeNumber.ToString();

            Random rand = new Random();

            int length = userId.ToString().Length + accountId.ToString().Length + strAccountType.Length;

            for (int i = 0; i < 16 - length; i++)
            {
                accountNumber += rand.Next(0, 9);
            }
            //Insert userId,accountId,typeNumber and space in Number of Account
            accountNumber = accountNumber.Insert(0, strAccountType).Insert(strAccountType.Length, accountId.ToString());

            return accountNumber = accountNumber.Insert(accountNumber.Length - 2, userId.ToString()).Insert(4, " ").Insert(9, " ").Insert(14, " ");
        }

    }
}
