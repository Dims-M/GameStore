using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameStore.Domain.Entities;
using System.Data.Entity;

namespace GameStore.Domain.Concrete
{
    //Класс привязка к бд ентинити
    public class EFDbContext : DbContext
    {
        public DbSet<Game> Games { get; set; }
    }
}