using GameStore.Domain.Abstract;
using GameStore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GameStore.WebUI.Controllers
{
    public class GameController : Controller
    {
        // GET: Game
        //public ActionResult Index()
        //{
        //    return View();
        //}

        private IGameRepository repository;
        /// <summary>
        /// Конструктор 
        /// </summary>
        /// <param name="repo"></param>
        public GameController(IGameRepository repo)
        {
            repository = repo;
        }

        //Получение списка товаров
        public ViewResult List()
        {
            return View(repository.Games);
        }


    }
}