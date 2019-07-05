
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

        //количество товара на страница сайта.
        public int pageSize = 4;

        /// <summary>
        /// Конструктор 
        /// </summary>
        /// <param name="repo"></param>
        public GameController(IGameRepository repo)
        {
            repository = repo;
        }

        //Получение списка товаров из хранилища Games
        public ViewResult List(int page = 1)
        {
            return View(repository.Games
                .OrderBy(game => game.GameId)
                .Skip((page - 1) * pageSize)
                .Take(pageSize));
        }

    }
}