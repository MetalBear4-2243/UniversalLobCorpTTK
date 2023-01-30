using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversalLobCorpTTK
{
    public static class GenericFunctions
    {
        public static string getName()
        {
            //possible error CS8600 V
            string name = "";
            if (name == "")
            {
                name = Console.ReadLine();
            }
            if (name == "")
            {
                name = getName();
            }
            //possible error CS8603    V
            return name;
        }

        public static void pauseForInput()
        {
            Console.Write("Press Enter to Continue");
            Console.Out.Flush();
            var tempName = Console.ReadLine();
        }
    }
}
