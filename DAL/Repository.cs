using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banking.Model;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Threading;

namespace Banking.DAL
{
    class Repository<T> : IRepository<T> where T : class
    {
        private readonly UserContext context;

        private string errorMessage = string.Empty;

        private IDbSet<T> entities;

        public Repository(UserContext context)
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

        public User GetByLogin(string login)
        {
            return context.Set<User>().FirstOrDefault(a => a.Login == login);
        }
    }
}
