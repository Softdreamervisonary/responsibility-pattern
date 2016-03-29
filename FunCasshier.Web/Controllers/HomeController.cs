using FunCashier.Servcie.Interface;
using FunCashier.Servcie.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FunCasshier.Web.Controllers
{
    public class HomeController : Controller
    {
        /// <summary>
        /// Using unity IOC 請參考Bootstrapper
        /// </summary>
        IUserService IUserService;
        public HomeController(IUserService _UserService)
        {
            this.IUserService = _UserService;
        }

        //測試是否有拿到資料
        public ActionResult Index()
        {
            var a = IUserService.GetAll().ToList();

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}