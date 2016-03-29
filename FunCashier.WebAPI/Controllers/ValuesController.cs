using FunCashier.Repository.Model;
using FunCashier.Servcie.Interface;
using FunCashier.Servcie.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FunCashier.WebAPI.Controllers
{
    //[Authorize]
    public class ValuesController : ApiController
    {


        public string Get()
        {
            UserService A = new UserService();
            List<Users> aa = A.GetAll().ToList();
            return "AA";
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
