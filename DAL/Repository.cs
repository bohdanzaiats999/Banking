using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banking.Entity;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Threading;

namespace Banking.DAL
{
    class Repository<T> : IRepository<T> where T : class
    {
        private readonly BankingContext context;

        private string errorMessage = string.Empty;

        private IDbSet<T> entities;

        public Repository(BankingContext context)
        {
            this.context = context;
            this.entities = context.Set<T>();

        }

        public void Insert(T entity)
        {
            try
            {
                if (entity == null)
                {
                    throw new ArgumentNullException("entity");
                }
                this.entities.Add(entity);
            }

            catch (DbEntityValidationException dbException)
            {

                foreach (var validationErrors in dbException.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        errorMessage += string.Format("Property: {0} Error: {1}", validationError.PropertyName,
                            validationError.ErrorMessage);
                    }
                }
                throw new Exception(errorMessage, dbException);
            }
        }

        public void Update(T entity)
        {
            try
            {
                if (entity == null)
                {
                    throw new ArgumentException("entity");
                }
                context.Entry(entity).State = EntityState.Modified;
            }
            catch (DbEntityValidationException dbException)
            {
                foreach (var validationErrors in dbException.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        errorMessage += Environment.NewLine + string.Format("Property: {0} Error: {1}",
                                            validationError.PropertyName, validationError.ErrorMessage);
                    }
                }
                throw new Exception(errorMessage, dbException);
            }
        }

        public void Delete(T entity)
        {
            try
            {
                if (entity == null)
                {
                    throw new ArgumentException("entity");
                }
                this.entities.Remove(entity);
            }
            catch (DbEntityValidationException dbException)
            {
                foreach (var validationErrors in dbException.EntityValidationErrors)
                {
                    foreach (var validationEror in validationErrors.ValidationErrors)
                    {
                        errorMessage += Environment.NewLine + string.Format("Property: {0} Error: {1}",
                                            validationEror.PropertyName, validationEror.ErrorMessage);
                    }
                }
                throw new Exception(errorMessage, dbException);
            }
        }

        public UserEntity GetByLogin(string login)
        {
            return context.Set<UserEntity>().FirstOrDefault(a => a.Login == login);
        }
        public T GetById(object id)
        {
            return this.entities.Find(id);
        }

        public IQueryable GetAccountById(int id)
        {
            return context.Set<AccountEntity>().Where(a => a.UserId == id);
        }

        public bool IsNumberAccount(string numberAccunt)
        {
            return context.Set<AccountEntity>().Any(a => a.Number == numberAccunt);

        }

        public IQueryable<AccountEntity> GetCurrentAccountsListById(int userId)
        {

            return context.Accounts.Where(a => a.UserId == userId);
        }

        public IQueryable<DepositEntity> GetDepositAccountsListById(int userId)
        {
            return context.Deposits.Where(a => a.UserId == userId);

        }

        public IQueryable<CreditEntity> GetCreditAccountsListById(int userId)
        {
            return context.Credits.Where(a => a.UserId == userId);

        }

        public void UpdateRange(IQueryable<T> entities)
        {
            try
            {
                foreach (var entity in entities.ToList())
                {
                    this.context.Entry(entity).State = EntityState.Modified;
                }
            }
            catch (DbEntityValidationException dbEx)
            {
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        errorMessage += Environment.NewLine + string.Format("Property: {0} Error: {1}",
                        validationError.PropertyName, validationError.ErrorMessage);
                    }
                }
                throw new Exception(errorMessage, dbEx);
            }
        }
    }
}
