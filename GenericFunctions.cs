using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversalLobCorpTTK
{
    public static class GenericFunctions
    {
        public static string GetName()
        {
            //possible error CS8600 V
            string? name = Console.ReadLine();

            name ??= GetName();
            //possible error CS8603    V
            return name;
        }

        public static void PauseForInput()
        {
            Console.Write("Press Enter to Continue");
            Console.Out.Flush();
            _ = Console.ReadLine();
        }
    }
}
