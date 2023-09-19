using Microsoft.EntityFrameworkCore;
using Ship_Battle_BASIC.Constructors;
using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Numerics;
using System.Windows.Forms;
using System.Xml;

namespace Ship_Battle_BASIC.DataBaseModels
{
    internal static class DataBaseManager
    {
        public static Player CheckPlayerAndGetPlayer(string userNameInput)
        {
            userNameInput = userNameInput.ToUpper();
            Player player = null;
            using (var context = new PlayerContext())
            {
                if (context.Players.Any(x => x.Name.Equals(userNameInput)))
                {
                    player = context.Players
                        .Include(p => p.PlayersLogs
                            .Where(pl=>pl.CloseddDate == null)
                            .OrderByDescending(pl=>pl.CreatedDate))
                        .FirstOrDefault(x =>x.Name.Equals(userNameInput));
                    return player;
                }
                else
                {
                    player = new Player(userNameInput.ToUpper(), 0, 0, 0, false);
                    context.Add(player);
                    context.SaveChanges();
                }
            }
            return player;
        }
        public static void UpdatePlayerDataToDb(Player player, string gameTable)
        {
            using (var context = new PlayerContext())
            {                
                context.Update<Player>(player);
                if (player.PlayersLogs.Count < 1)
                {
                    PlayersLog playersLog = new PlayersLog(player.Id, gameTable);
                    if (player.MachInProgress == false)
                        playersLog.CloseddDate = DateTime.Now;
                    player.PlayersLogs.Add(playersLog);
                }
                else
                {
                    if (player.MachInProgress == false)
                        player.PlayersLogs.First().CloseddDate = DateTime.Now;
                    context.Update<PlayersLog>(player.PlayersLogs.First());
                }
                context.SaveChanges();
            } 
        }
    }
}
