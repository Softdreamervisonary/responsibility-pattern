using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FunCashier.Repository.Model;

namespace FunCashier.Repository.Interface
{
    /// <summary>
    /// 繼承最底層的IReposory若要實作User專屬的資料存取，請在此開方法並到UserRepository實作
    /// </summary>
    public interface IUsersRepository : IRepository<Users>
    {
    }
}
