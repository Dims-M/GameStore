﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Web.Mvc;
using Moq;
using Ninject;
using GameStore.Domain.Abstract;
using GameStore.Domain.Entities;
using GameStore.Domain.Concrete;


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

        /// <summary>
        /// Метод привязки. для хранилищь
        /// </summary>
        private void AddBindings()
        {
            // Здесь размещаются привязки
            kernel.Bind<IGameRepository>().To<EFGameRepository>();
            //        Mock<IGameRepository> mock = new Mock<IGameRepository>();
            //        mock.Setup(m => m.Games).Returns(new List<Game>
            //{
            //    new Game { Name = "SimCity", Price = 1499 },
            //    new Game { Name = "TITANFALL", Price=2299 },
            //    new Game { Name = "Battlefield 4", Price=899.4M }
            //});
            //        kernel.Bind<IGameRepository>().ToConstant(mock.Object);
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