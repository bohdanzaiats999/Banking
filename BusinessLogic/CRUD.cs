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
            if (user != null && login == user.Login && password == user.Password)
            {
                return true;
            }
            return false;
        }

        public bool OpenBill(string login, string password)
        {
            
            if (login != "" & password != "")
            {

                user = db.Repository<User>().GetByLogin(login);

                if (user == null)
                {
                    db.Repository<User>().Insert(new User {Login = login, Password = password, Money = 0});
                    db.SaveChanges();
                    MessageBox.Show("Registration was successful");
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

        public string AccountStatus()
        {
            return user.Money.ToString();
        }
    }
}
