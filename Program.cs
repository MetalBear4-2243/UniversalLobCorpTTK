using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversalLobCorpTTK
{
    class MainMethod
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Lobotomy Corporation TTK Checker.");
            Console.WriteLine("This tool will allow you to roughly estimate the time to kill a target given one attacker.");
            Console.WriteLine("This will only give a rough estimate, and should not be regarded as completely accurate.");
            
            Console.WriteLine("Input the Weapon of the Employee:");
            string SelectedWeapon = GenericFunctions.getName();
            GetInputs.SetArray(SelectedWeapon);
            
            GetInputs.AssignValues();

            double average = MathFunctions.Average(GetInputs.TargetHealth, GetInputs.Justice, GetInputs.DamageMult, GetInputs.SwingSpeed, GetInputs.MinDam, GetInputs.MaxDam, GetInputs.Hits, GetInputs.AttackingLevel, GetInputs.DefendingLevel);
            Console.WriteLine($"Your average Time to Kill is {average} seconds.");
            GenericFunctions.pauseForInput();
        }
    }
}