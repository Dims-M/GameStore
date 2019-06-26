using System;
using System.Collections.Generic;
using System.Configuration;
using System.Web.Mvc;
using Moq;
using Ninject;

namespace GameStore.WebUI.Infrastructure
{
    /// <summary>
    /// Класс специального распознавателя зависимостей 
    /// </summary>
    public class NinjectDependencyResolver : IDependencyResolver
    {
        private IKernel kernel;

        public NinjectDependencyResolver(IKernel kernelParam)
        {
            kernel = kernelParam;
            AddBindings();
        }

        public object GetService(Type serviceType)
        {
            return kernel.TryGet(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return kernel.GetAll(serviceType);
        }

        private void AddBindings()
        {
            // Здесь размещаются привязки
        }

        /// <summary>
        /// Метод шлюза ??????
        /// </summary>
        /// <param name="kernel"></param>
        private static void RegisterServices(IKernel kernel)
        {
            System.Web.Mvc.DependencyResolver.SetResolver(new
                GameStore.WebUI.Infrastructure.NinjectDependencyResolver(kernel));
        }
    }
}