using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameStore.Domain.Entities;

namespace GameStore.Domain.Abstract
{
    /// <summary>
    /// Интерфейс для извлечении последовательность объектов Game
    /// </summary>
  public  interface IGameRepository
    {
        //Коллекция для игр.
        IEnumerable<Game> Games { get; }
    }
}
