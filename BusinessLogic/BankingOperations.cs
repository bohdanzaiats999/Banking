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
    class BankingOperations
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

        public List<DepositEntity> GetDepositList()
        {

            List<DepositEntity> accountsList = db.Repository<DepositEntity>().GetDepositAccountsListById(userId).ToList();
            return accountsList;
        }

        public List<AccountEntity> GetCurrentList()
        {

            List<AccountEntity> accountsList = db.Repository<AccountEntity>().GetCurrentAccountsListById(userId).ToList();
            return accountsList;
        }

        public List<CreditEntity> GetCreditList()
        {
            List<CreditEntity> accountsList = db.Repository<CreditEntity>().GetCreditAccountsListById(userId).ToList();
            return accountsList;
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

        public void AddDeposit(string interestRate, string money)
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

            return accountNumber = accountNumber.Insert(accountNumber.Length - 2, userId.ToString());
        }

        public void CloseAccount(string numberAccount, AccountType type)
        {
            switch (type)
            {
                case AccountType.Account:
                    var accountEntity = db.Repository<AccountEntity>().GetCurrentAccountsListById(userId).FirstOrDefault(x => x.Number == numberAccount);
                    db.Repository<AccountEntity>().Delete(accountEntity);
                    break;
                case AccountType.Credit:
                    var creditEntity = db.Repository<CreditEntity>().GetCreditAccountsListById(userId).FirstOrDefault(x => x.Number == numberAccount);
                    if (creditEntity.Money > 0)
                    {
                        throw new Exception("You cannot close the account, account has a negative balance");
                    }
                    db.Repository<CreditEntity>().Delete(creditEntity);
                    break;
                case AccountType.Deposit:
                    var depositEntity = db.Repository<DepositEntity>().GetDepositAccountsListById(userId).FirstOrDefault(x => x.Number == numberAccount);
                    db.Repository<DepositEntity>().Delete(depositEntity);
                    break;
            }
            db.SaveChanges();
        }

        public void AccrualInterest()
        {
            var deposits = db.Repository<DepositEntity>().GetDepositAccountsListById(userId);

            if (deposits.Count() != 0 )
            {
                foreach (var deposit in deposits)
                {
                    TimeSpan differenceInDays = deposit.LastDateAccrued - DateTime.Now;
                    if (differenceInDays.Days > 30)
                    {
                        deposit.Money += (deposit.Money * deposit.InterestRate) / 100;
                        deposit.LastDateAccrued += TimeSpan.FromDays(30);
                    }
                }
                db.Repository<DepositEntity>().UpdateRange(deposits);
                db.SaveChanges();
            }

            var credits = db.Repository<CreditEntity>().GetCreditAccountsListById(userId);
            if (credits.Count() != 0)
            {
                foreach (var credit in credits)
                {
                    TimeSpan differenceInDays = credit.LastDateAccrued - DateTime.Now;

                    if (differenceInDays.Days > 30)
                    {
                        credit.Money += (credit.Money * credit.InterestRate) / 100;
                        credit.LastDateAccrued += TimeSpan.FromDays(30);
                    }
                }
                db.Repository<CreditEntity>().UpdateRange(credits);
                db.SaveChanges();
            }
        }
    }
}
