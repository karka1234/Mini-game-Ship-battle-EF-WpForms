using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ship_Battle_BASIC.DataBaseModels
{
    internal class DataBaseManager
    {
        public static void CheckUser()
        { 
            using var context = new PlayerContext();

        }


    }
}
