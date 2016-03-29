using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FunCashier.Repository.Interface;
using System.Data.Entity;
using FunCashier.Repository.Model;
using System.Linq.Expressions;

namespace FunCashier.Repository.Repository
{
    public class UsersRepository : IUsersRepository
    {
        protected UsersBlogContext db
        {
            get;
            private set;
        }

        public UsersRepository()
        {
            this.db = new UsersBlogContext();
        }

        public void Create(Users instance)
        {
            if (instance == null)
            {
                throw new ArgumentNullException("instance");
            }
            else
            {
                db.Users.Add(instance);
                this.SaveChanges();
            }
        }

        public void Update(Users instance)
        {
            if (instance == null)
            {
                throw new ArgumentNullException("instance");
            }
            else
            {
                db.Entry(instance).State = EntityState.Modified;
                this.SaveChanges();
            }
        }

        public void Delete(Users instance)
        {
            if (instance == null)
            {
                throw new ArgumentNullException("instance");
            }
            else
            {
                db.Entry(instance).State = EntityState.Deleted;
                this.SaveChanges();
            }
        }

        public Users Get(Guid userID)
        {
            return db.Users.FirstOrDefault(x => x.Id == userID);
        }

        public IQueryable<Users> GetAll()
        {
            return db.Users.Include(p => p.Id).OrderByDescending(x => x.Id);
        }

        public void SaveChanges()
        {
            this.db.SaveChanges();
        }

        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (this.db != null)
                {
                    this.db.Dispose();
                    this.db = null;
                }
            }
        }

        public Users Get(Expression<Func<Users, bool>> predicate)
        {
            throw new NotImplementedException();
        }
    }
}