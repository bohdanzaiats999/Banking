using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking.DAL
{
    interface IUnitOfWork
    {
        Repository<T> Repository<T>() where T : class;

        void SaveChanges();

    }
}
