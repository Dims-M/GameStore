
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GameStore.Domain.Abstract;
using GameStore.Domain.Entities;

namespace GameStore.WebUI.Controllers
{

    /// <summary>
    /// Контролер.  
    /// </summary>
    public class GameController : Controller
    {
   
        private IGameRepository repository;
        /// <summary>
        /// Конструктор 
        /// </summary>
        /// <param name="repo"></param>
        public GameController(IGameRepository repo)
        {
            repository = repo;
        }

        //Получение списка товаров из хранилища Games
        public ViewResult List()
        {
            return View(repository.Games);
        }


    }
}