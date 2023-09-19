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
                    return GetPlayer(userNameInput, context);
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

        private static Player GetPlayer(string userNameInput, PlayerContext context)
        {
            return context.Players
                .Include(p => p.PlayersLogs
                    .Where(pl => pl.CloseddDate == null)
                    .OrderByDescending(pl => pl.CreatedDate))
                .FirstOrDefault(x => x.Name.Equals(userNameInput));
        }

        public static void UpdatePlayerDataToDb(Player player, string gameTable)
        {
            using (var context = new PlayerContext())
            {                
                context.Update<Player>(player);
                if (player.PlayersLogs.Count < 1)//kazkaip pakeist... jei nera tiesiog kuriam nauja
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

        public static void GetAllPlayersStatsAndSetToView(DataGridView dataGridView)
        {
            using var context = new PlayerContext();
            var playerStats = context.Players.Select(x => new { x.Name, x.TotalMachesPlayed, x.TotalScore, x.MachInProgress }).ToList();
            dataGridView.DataSource = playerStats;
        }

    }
}
