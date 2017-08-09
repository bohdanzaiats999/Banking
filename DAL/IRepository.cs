using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banking.Entity;

namespace Banking.DAL
{
    interface IRepository<T> where T : class
    {
        UserEntity GetByLogin(string login);
        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
