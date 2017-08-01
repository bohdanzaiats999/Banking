using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Banking.Model;
using System.Windows.Forms;
using Banking.DAL;
using System.Security.Cryptography;

namespace Banking.BusinessLogic
{
    public class BankingOperations
    {
        private User user;
        private readonly UnitOfWork db;

        public BankingOperations()
        {
            db = new UnitOfWork();
        }

        // Log In
        public bool IsLogIn(string login, string password)
        {
            if (login != "" && password != "")
            {
                user = db.Repository<User>().GetByLogin(login);
                if (user != null)
                {
                    AesCrypt aes = new AesCrypt();
                    string cryptedPassword = aes.EncryptAes(password);

                    if (cryptedPassword == user.Password)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        // Registration
        public bool IsOpenBill(string login, string password)
        {

            if (login != "" & password != "")
            {
                user = db.Repository<User>().GetByLogin(login);

                if (user == null)
                {
                    AesCrypt aes = new AesCrypt();
                    string encryptedPassword = aes.EncryptAes(password);

                    string numberAccount = GenerateAccountNumber();

                    db.Repository<CurrentAccount>()
                        .Insert(new CurrentAccount
                        {
                            User = new User {Login = login, Password = encryptedPassword},
                            Money = 0,
                            Number = numberAccount
                        });
                    db.SaveChanges();
                    user = db.Repository<User>().GetByLogin(login);
                    return true;
                }
            }
            return false;
        }

        // Generate Account Number
        private string GenerateAccountNumber()
        {
            string numberAccount = string.Empty;
            Random rand = new Random();
            do
            {
                for (int i = 0; i < 4; i++)
                {
                    numberAccount += string.Format(rand.Next(1000, 9999).ToString() + " ");
                }

            } while (db.Repository<CurrentAccount>().IsNumberAccount(numberAccount));
            return numberAccount;
        }
        
        public void FillCurrentAccountComboBox(ComboBox comboBox)
        {
            comboBox.DataSource = db.Repository<CurrentAccount>().GetCurrentAccountsListById(user.Id);
            comboBox.DisplayMember = "Number";
        }

        public void FillDepositAccountComboBox(ComboBox comboBox)
        {
            comboBox.DataSource = db.Repository<DepositAccount>().GetDepositAccountsListById(user.Id);
            comboBox.DisplayMember = "Number";
        }

        public void FillCreditAccountComboBox(ComboBox comboBox)
        {
            comboBox.DataSource = db.Repository<CreditAccount>().GetCreditAccountsListById(user.Id);
            comboBox.DisplayMember = "Number";
        }

        public void AddCurrentAccount()
        {
                  string numberAccount = GenerateAccountNumber();
                    db.Repository<CurrentAccount>()
                        .Insert(new CurrentAccount
                        {
                            User = user,
                            Money = 0,
                            Number = numberAccount
                        });
                    db.SaveChanges();
        }

        public void AddDepositAccount()
        {
            
        }

        public void AddCreditAccount()
        {
            
        }


    }
}
