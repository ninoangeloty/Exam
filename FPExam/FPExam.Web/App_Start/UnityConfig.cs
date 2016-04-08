using System.Web.Mvc;
using Microsoft.Practices.Unity;
using Unity.Mvc5;
using FPExam.Data;
using FPExam.Services;
using FPExam.Entity;

namespace FPExam.Web
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            
            // register all your components with the container here
            // it is NOT necessary to register your controllers
            
            // e.g. container.RegisterType<ITestService, TestService>();

            container.RegisterType<IUnitOfWork, UnitOfWork<ExamContext>>();
            container.RegisterType<ICounterService, CounterService>();
            
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}