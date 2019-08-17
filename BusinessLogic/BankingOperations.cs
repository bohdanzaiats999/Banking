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

        public ICollection<DepositEntity> GetDepositList()
        {

            ICollection<DepositEntity> accountsList = db.Repository<DepositEntity>().GetDepositListById(userId).ToList();
            return accountsList;
        }

        public ICollection<AccountEntity> GetCurrentList()
        {

            ICollection<AccountEntity> accountsList = db.Repository<AccountEntity>().GetAccountsListById(userId).ToList();
            return accountsList;
        }

        public ICollection<CreditEntity> GetCreditList()
        {
            ICollection<CreditEntity> accountsList = db.Repository<CreditEntity>().GetCreditListById(userId).ToList();
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
                    Money = decimal.Parse(money),
                    InterestRate = decimal.Parse(interestRate),
                    LastDateAccrued = DateTimeOffset.Now
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
                    Money = -(decimal.Parse(money)),
                    InterestRate = decimal.Parse(interestRate),
                    LastDateAccrued = DateTimeOffset.Now,
                    MonthlyPayment = decimal.Parse(monthlyPayment),
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
                    var accountEntity = db.Repository<AccountEntity>().GetAccountsListById(userId).FirstOrDefault(x => x.Number == numberAccount);
                    db.Repository<AccountEntity>().Delete(accountEntity);
                    break;
                case AccountType.Credit:
                    var creditEntity = db.Repository<CreditEntity>().GetCreditListById(userId).FirstOrDefault(x => x.Number == numberAccount);
                    if (creditEntity.Money < 0)
                    {
                        throw new Exception("You cannot close the account, account has a negative balance");
                    }
                    db.Repository<CreditEntity>().Delete(creditEntity);
                    break;
                case AccountType.Deposit:
                    var depositEntity = db.Repository<DepositEntity>().GetDepositListById(userId).FirstOrDefault(x => x.Number == numberAccount);
                    db.Repository<DepositEntity>().Delete(depositEntity);
                    break;
            }
            db.SaveChanges();

        }

        public void AccrualInterest()
        {
            var deposits = db.Repository<DepositEntity>().GetDepositListById(userId);

            if (deposits.Count() != 0)
            {
                foreach (var deposit in deposits)
                {
                    TimeSpan differenceInDays = DateTimeOffset.Now - deposit.LastDateAccrued;
                    while (differenceInDays.Days > 30)
                    {
                        deposit.Money += (deposit.Money * deposit.InterestRate) / 100;
                        deposit.LastDateAccrued = deposit.LastDateAccrued.AddDays(30);
                    }
                }
                db.Repository<DepositEntity>().UpdateRange(deposits);
                db.SaveChanges();
            }

            var credits = db.Repository<CreditEntity>().GetCreditListById(userId);
            if (credits.Count() != 0)
            {
                foreach (var credit in credits)
                {
                    TimeSpan differenceInDays = DateTimeOffset.Now - credit.LastDateAccrued;

                    while (differenceInDays.Days > 30)
                    {
                        credit.Money += (credit.Money * credit.InterestRate) / 100;
                        credit.LastDateAccrued = credit.LastDateAccrued.AddDays(30);
                    }
                }
                db.Repository<CreditEntity>().UpdateRange(credits);
                db.SaveChanges();
            }
        }

        public void RefillAccount(string money, AccountType type, int index)
        {
            if (money == string.Empty && decimal.Parse(money) > 0)
            {
                throw new Exception("Fill in the money field");
            }
            switch (type)
            {
                case AccountType.Account:
                    var accounts = db.Repository<AccountEntity>().GetAccountsListById(userId);
                    accounts.ToList()[index].Money += decimal.Parse(money);
                    db.Repository<AccountEntity>().UpdateRange(accounts);
                    db.SaveChanges();
                    break;
                case AccountType.Deposit:
                    var deposits = db.Repository<DepositEntity>().GetDepositListById(userId);
                    deposits.ToList()[index].Money += decimal.Parse(money);
                    db.Repository<DepositEntity>().UpdateRange(deposits);
                    db.SaveChanges();
                    break;
                case AccountType.Credit:
                    var credits = db.Repository<CreditEntity>().GetCreditListById(userId);
                    credits.ToList()[index].Money += decimal.Parse(money);
                    db.Repository<CreditEntity>().UpdateRange(credits);
                    db.SaveChanges();
                    break;
            }
        }

        public void SendMoney(string money, int index, string payeeNumber)
        {
            decimal sendMoney = decimal.Parse(money);

            if (money == string.Empty && sendMoney > 0)
            {
                throw new Exception("Fill in the money field");
            }
            if (payeeNumber == string.Empty)
            {
                throw new Exception("Fill in the number field");
            }

            var accountRecipient = db.Repository<AccountEntity>().GetAccountByNumber(payeeNumber);
            if (accountRecipient == null)
            {
                throw new Exception("User not found");
            }
            var accounts = db.Repository<AccountEntity>().GetAccountsListById(userId);
            if (accounts.ToList()[index].Money > sendMoney)
            {
                accounts.ToList()[index].Money -= sendMoney;
                accountRecipient.Money += sendMoney;

                db.Repository<AccountEntity>().UpdateRange(accounts);
                db.Repository<AccountEntity>().Update(accountRecipient);
                db.SaveChanges();
            }
        }
    }
}

