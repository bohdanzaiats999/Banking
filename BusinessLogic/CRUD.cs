using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Banking.Model;
using System.Windows.Forms;

namespace Banking.BusinessLogic
{
    public class CRUD
    {
        UserContext context = new UserContext();
        User log;


        public bool LogIn(string login, string password)
        {
            log = context.Users.FirstOrDefault(a => a.Login == login);
            if (log != null && login == log.Login && password == log.Password)
            {
                return true;
            }
            return false;
        }

        public bool Registration(string login, string password)
        {
            if (login != "" & password != "")
            {

                log = context.Users.FirstOrDefault(a=>a.Login == login);

                if (log == null)
                {
                    context.Users.Add(new User { Login = login, Password = password, Money = 0 });
                    context.SaveChanges();
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
    }
}
