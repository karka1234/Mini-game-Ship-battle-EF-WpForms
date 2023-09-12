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
                {///////////////////////atsijaunint ef reik

                    player = context.Players
                        .Include(p => p.PlayersLogs)
                        .FirstOrDefault(x =>x.Name.Equals(userNameInput));


                    return player;
                    //player = context.Players.First(x => x.Name.Equals(userNameInput)).Incl
                    //player.PlayersLogs.Add(context.PlayerLogs.First(x => x.PlayerId == player.Id && x.CloseddDate == DateTime.MinValue));
                }
                else
                {//registracija galima kazkokia padaryt
                    player = new Player(userNameInput.ToUpper(), 0, 0, 0, false);
                    context.Add(player);
                    context.SaveChanges();
                }
            }
            return player;
        }


        public static void UpdatePlayerDataToDb(Player player, string gameTable)//sukurti arba atnaujinti ir player log
        {
            using (var context = new PlayerContext())
            {                
                context.Update<Player>(player);                               
                PlayersLog playersLog = new PlayersLog(player.Id, gameTable);
                if(player.MachInProgress == false)
                    playersLog.CloseddDate = DateTime.Now;
                player.PlayersLogs.Add(playersLog);
                context.SaveChanges();
            } 
        }

        public static string GetGameTable(Guid playerId)
        {
            PlayersLog playersLog = new PlayersLog();
            using (var context = new PlayerContext())
            {
                if (context.PlayerLogs.Any(x => x.PlayerId == playerId && x.CloseddDate == DateTime.MinValue))
                {
                    playersLog = context.PlayerLogs.First(x => x.PlayerId == playerId && x.CloseddDate == DateTime.MinValue);
                    return playersLog.GameTable;
                }
            }
            return "";
        }



    }
}
