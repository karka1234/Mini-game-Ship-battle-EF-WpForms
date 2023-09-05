using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ship_Battle_BASIC.DataBaseModels
{
    internal static class DataBaseConnection
    {
        public const string connectionString = @"Server=SMEKLA\MYLOCALDATABASE;Database=ShipBattle;Trusted_Connection=True;TrustServerCertificate=true";
    }
}
