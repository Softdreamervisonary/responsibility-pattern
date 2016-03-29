using FunCashier.Repository.Interface;
using FunCashier.Repository.Model;
using FunCashier.Repository.Repository;
using FunCashier.Servcie.Interface;
using FunCashier.Servcie.Misc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunCashier.Servcie.Service
{
    public class UserService : IUserService
    {
        private IUsersRepository _repository;

        /// <summary>
        /// 使用IOC請參考
        /// </summary>
        /// <param name="repository"></param>
        public UserService(IUsersRepository repository)
        {
            this._repository = repository;
        }

        public IResult Create(Users instance)
        {
            if (instance == null)
            {
                throw new ArgumentNullException();
            }

            IResult result = new Result(false);
            try
            {
                this._repository.Create(instance);
                result.Success = true;
            }
            catch (Exception ex)
            {
                result.Exception = ex;
            }
            return result;
        }

        public IResult Update(Users instance)
        {
            if (instance == null)
            {
                throw new ArgumentNullException();
            }

            IResult result = new Result(false);
            try
            {
                this._repository.Update(instance);
                result.Success = true;
            }
            catch (Exception ex)
            {
                result.Exception = ex;
            }
            return result;
        }

        public IResult Delete(Guid UsersID)
        {
            IResult result = new Result(false);

            if (!this.IsExists(UsersID))
            {
                result.Message = "找不到資料";
            }

            try
            {
                var instance = this.GetByID(UsersID);
                this._repository.Delete(instance);
                result.Success = true;
            }
            catch (Exception ex)
            {
                result.Exception = ex;
            }
            return result;
        }

        public bool IsExists(Guid UsersID)
        {
            return this._repository.GetAll().Any(x => x.Id == UsersID);
        }

        public Users GetByID(Guid guid)
        {
            return this._repository.Get(x=>x.Id==guid);
        }

        public IEnumerable<Users> GetAll()
        {
            return this._repository.GetAll();
        }
    }
}
