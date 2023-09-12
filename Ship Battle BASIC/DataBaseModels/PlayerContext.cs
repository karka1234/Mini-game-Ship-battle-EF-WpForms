using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.Extensions.Options;
using Ship_Battle_BASIC.Constructors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ship_Battle_BASIC.DataBaseModels
{
    internal class PlayerContext : DbContext
    {
        public DbSet<Player> Players { get; set; }
        public DbSet<PlayersLog> PlayerLogs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder              
                .UseSqlServer(DataBaseConnection.connectionString);
        }
    }
}
