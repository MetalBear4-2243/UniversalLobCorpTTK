using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversalLobCorpTTK
{
    public static class WeaponArrays
    {
        
        public readonly static String[] Penitence = new string[6] { "Penitence", "Zayin", "White", "5", "7", "0.5" };
        public readonly static Dictionary<string, string[]> penitence = new()
        {
            {"Penitence", Penitence }
        };

        public readonly static String[] Soda = new string[6] { "Soda", "Zayin", "Red", "1", "2", "0.5" };
        public readonly static Dictionary<string, string[]> soda = new()
        {
            {"Soda", Soda }
        };
    }
}
