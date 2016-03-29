using FunCashier.Repository.Model;
using FunCashier.Servcie.Misc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunCashier.Servcie.Interface
{
    public interface IUserService
    {
        IResult Create(Users instance);

        IResult Update(Users instance);

        IResult Delete(Guid UsersID);

        bool IsExists(Guid UsersID);

        Users GetByID(Guid UsersID);

        IEnumerable<Users> GetAll();

    }
}
