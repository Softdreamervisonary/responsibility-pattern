using FunCashier.Repository.Interface;
using FunCashier.Repository.Repository;
using FunCashier.Servcie.Interface;
using FunCashier.Servcie.Service;
using Microsoft.Practices.Unity;
using System.Web.Http;
using Unity.WebApi;
using System;
using FunCashier.WebAPI.Controllers;

namespace FunCashier.WebAPI
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = BuildUnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();




            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
           
        }


        private static IUnityContainer BuildUnityContainer()
        {
            var container = new UnityContainer();

            // register all your components with the container here
            // e.g. container.RegisterType<ITestService, TestService>();
            container.RegisterType<IUserService, UserService>();
            return container;
        }

        public static void RegisterTypes(IUnityContainer container)
        {


        }

    }
}