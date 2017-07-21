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
    public class CRUD
    {
        private User user;
        private readonly UnitOfWork db;

        public CRUD()
        {
            db = new UnitOfWork();
        }

        public bool LogIn(string login, string password)
        {
            user = db.Repository<User>().GetByLogin(login);

            if (user != null)
            {
                AesCrypt aes = new AesCrypt();
                string descryptedPassword = aes.DecryptAes(user.Password);

                if (password == descryptedPassword)
                {
                    return true;
                }
            }
            return false;
        }

        public bool GetCash(string amount)
        {
            int money = int.Parse(amount);
            if (amount != "" && money > 0 && money <= user.Money)
            {
                user.Money -= money;
                db.Repository<User>().Update(user);
                db.SaveChanges();
                MessageBox.Show("The amount of money has been successfully withdrawn from the account");
                return true;
            }
            MessageBox.Show("Insufficient funds on the account");
            return false;
        }

        public bool OpenBill(string login, string password)
        {

            if (login != "" & password != "")
            {

                user = db.Repository<User>().GetByLogin(login);

                if (user == null)
                {
                    AesCrypt aes = new AesCrypt();
                    string encryptedPassword = aes.EncryptAes(password);
                    db.Repository<User>().Insert(new User {Login = login, Password = encryptedPassword, Money = 0});
                    db.SaveChanges();
                    MessageBox.Show("Registration was successful");
                    user = db.Repository<User>().GetByLogin(login);
                    return true;
                }
                else
                {
                    MessageBox.Show("This Login already exist");
                }
            }
            return false;
        }

        public void Refill(string amount)
        {
            user.Money += int.Parse(amount);
            db.Repository<User>().Update(user);
            db.SaveChanges();

        }

        public bool ToSendMoney(string receiverLogin, string amount)
        {
            if (receiverLogin != "" && amount!= "")
            {
                User receiver = db.Repository<User>().GetByLogin(receiverLogin);

                int money = int.Parse(amount);
                if (receiver != null && user.Money >= money && money > 0)
                {
                    receiver.Money += money;
                    user.Money -= money;
                    db.Repository<User>().Update(user);
                    db.Repository<User>().Update(receiver);
                    db.SaveChanges();
                    MessageBox.Show("Operation was successful");
                    return true;
                }
                MessageBox.Show("User not found or no enough money on account"); 
            }
            return false;
        }

        public string AccountStatus()
        {
            return user.Money.ToString();
        }

    }
}
