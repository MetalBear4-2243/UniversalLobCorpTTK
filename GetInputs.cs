using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace UniversalLobCorpTTK
{
    public static class GetInputs
    {
        public static int TargetHealth = 0;
        public static int Justice = 0;
        public static double DamageMult = 0;
        public static double SwingSpeed = 0;
        public static int MinDam = 0;
        public static int MaxDam = 0;
        public static int Hits = 0;
        public static int AttackingLevel = 0;
        public static int DefendingLevel = 0;
        /*
        public static Array GetWeapon(string WeaponName)
        {
             string Weapon = WeaponName;
            string[6] CurrentWeapon = new string[] { };
                switch (Weapon)
                {
                    case "Penitence":
                        LevelMult = 0.4;
                        break;
                    case -3:
                        LevelMult = 0.6;
                        break;
                    case -2:
                        LevelMult = 0.7;
                        break;
                    case -1:
                        LevelMult = 0.8;
                        break;
                    case 0:
                        LevelMult = 1;
                        break;
                    case 1:
                        LevelMult = 1;
                        break;
                    case 2:
                        LevelMult = 1.2;
                        break;
                    case 3:
                        LevelMult = 1.5;
                        break;
                    case 4:
                        LevelMult = 2;
                        break;
                    default:
                        LevelMult = 1;
                        break;
                }

        }
        *///array function
        public static void AssignValues()
        {
            TargetHealth = GetTargetHealth();
            Justice = GetJustice();
            DamageMult = GetDamageMult();
            SwingSpeed = GetSwingSpeed();
            MinDam = GetMinDam();
            MaxDam = GetMaxDam();
            Hits = GetHits();            
        }
        
        public static int GetTargetHealth()
        {
            Console.WriteLine("Input the Target Health Stat:");
            string HealthInput = GenericFunctions.getName();
            int Target = Convert.ToInt32(HealthInput);
            return Target;
        }

        public static int GetJustice()
        {
            Console.WriteLine("Input the Employee Justice Stat:");
            string JusticeInput = GenericFunctions.getName();
            int Justice = Convert.ToInt32(JusticeInput);
            return Justice;
        }
        public static double GetDamageMult()
        {
            Console.WriteLine("Input the Damage Multiplier Stat:");
            string DamageMultInput = GenericFunctions.getName();
            double DamageMultiple = Convert.ToDouble(DamageMultInput);
            return DamageMultiple;
        }

        public static double GetSwingSpeed()
        {
            Console.WriteLine("Input the Default Weapon Swing Speed:");
            Console.WriteLine("Find the information here:\nhttps://docs.google.com/spreadsheets/d/1FOWhLx4k-9IUguEBR_2qyemry2hi4_HMYS0opBAUnak/htmlview");
            string SwingSpeedInput = GenericFunctions.getName();
            double SpeedMultiple = Convert.ToDouble(SwingSpeedInput);
            return SpeedMultiple;
        }

        public static int GetMinDam()
        {
            Console.WriteLine("Input the Minimum Damage Roll:");
            string MinInput = GenericFunctions.getName();
            int Min = Convert.ToInt32(MinInput);
            return Min;
        }

        public static int GetMaxDam()
        {
            Console.WriteLine("Input the Minimum Damage Roll (If no variance in roll, input same value as minimum:");
            string MaxInput = GenericFunctions.getName();
            int Max = Convert.ToInt32(MaxInput);
            return Max;
        }

        public static int GetHits()
        {
            Console.WriteLine("Input the Amount of Times Damage is Calculated Per Hit");
            string HitInput = GenericFunctions.getName();
            int Hits = Convert.ToInt32(HitInput);
            return Hits;
        }
    }
}
