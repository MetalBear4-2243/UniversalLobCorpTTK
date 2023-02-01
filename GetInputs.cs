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
        public static int DefendingLevel = 0;
        public static int Justice = 0;
        public static string WeaponName = "";
        public static string WeaponClass = "";
        public static int AttackingLevel = 0;
        public static string DamageType = "";
        public static double DamageMult = 0;
        public static double SwingSpeed = 0;
        public static int MinDam = 0;
        public static int MaxDam = 0;
        public static int Hits = 0;
        
        public static void SetArray(string SelectedWeapon)
        {
            switch (SelectedWeapon)
            {
                case "Penitence":
                    SetWeapon(WeaponArrays.Penitence);
                    break;
                case "Soda":
                    SetWeapon();
                    break;
                case "Tough":
                    SetWeapon();
                    break;
                case "Wingbeat":
                    SetWeapon();
                    break;
                case "Pink":
                    SetWeapon();
                    break;
                case "Training Standard EGO":
                    SetWeapon();
                    break;
                case "Fourth Match Flame":
                    SetWeapon();
                    break;
                case "Loneliness":
                    SetWeapon();
                    break;
                case "Screaming Wedge":
                    SetWeapon();
                    break;
                case "Red Eyes":
                    SetWeapon();
                    break;
                case "Horn":
                    SetWeapon();
                    break;
                case "Wrist Cutter":
                    SetWeapon();
                    break;
                case "Regret":
                    SetWeapon();
                    break;
                case "Beak":
                    SetWeapon();
                    break;
                case "Somewhere Spear":
                    SetWeapon();
                    break;
                case "Life for the Daredevil":
                    SetWeapon();
                    break;
                case "Lantern":
                    SetWeapon();
                    break;
                case "Today's Expression":
                    SetWeapon();
                    break;
                case "Rapturous Dream":
                    SetWeapon();
                    break;
                case "Cherry Blossom":
                    SetWeapon();
                    break;
                case "CUTE!!!":
                    SetWeapon();
                    break;
                case "Bear Paw":
                    SetWeapon();
                    break;
                case "Bloody Desire":
                    SetWeapon();
                    break;
                case "Crier":
                    SetWeapon();
                    break;
                case "Harmony":
                    SetWeapon();
                    break;
                case "Logging":
                    SetWeapon();
                    break;
                case "Frost Shard":
                    SetWeapon();
                    break;
                case "Grinder Mk4":
                    SetWeapon();
                    break;
                case "Christmas":
                    SetWeapon();
                    break;
                case "Galaxy":
                    SetWeapon();
                    break;
                case "Laetitia":
                    SetWeapon();
                    break;
                case "Magic Bullet":
                    SetWeapon();
                    break;
                case "Gaze":
                    SetWeapon();
                    break;
                case "Pleasure":
                    SetWeapon();
                    break;
                case "Harvest":
                    SetWeapon();
                    break;
                case "Justitia":
                    SetWeapon();
                    break;
                case "Green Stem":
                    SetWeapon();
                    break;
                case "Lamp":
                    SetWeapon();
                    break;
                case "Blue Scar":
                    SetWeapon();
                    break;
                case "Crimson Scar":
                    SetWeapon();
                    break;
                case "Black Swam":
                    SetWeapon();
                    break;
                case "Gold Rush":
                    SetWeapon();
                    break;
                case "Ecstasy":
                    SetWeapon();
                    break;
                case "Diffraction":
                    SetWeapon();
                    break;
                case "Amita":
                    SetWeapon();
                    break;
                case "A Sword Sharpened By Tears":
                    SetWeapon();
                    break;
                case "Heaven":
                    SetWeapon();
                    break;
                case "Hornet":
                    SetWeapon();
                    break;
                case "Hypocrisy":
                    SetWeapon();
                    break;
                case "Reverberation":
                    SetWeapon();
                    break;
                case "ShedSkin":
                    SetWeapon();
                    break;
                case "Discord":
                    SetWeapon();
                    break;
                case "Feather Of Honor":
                    SetWeapon();
                    break;
                case "Spore":
                    SetWeapon();
                    break;
                case "Moonlight":
                    SetWeapon();
                    break;
                case "Mimicry":
                    SetWeapon();
                    break;
                case "Sound Of A Star":
                    SetWeapon();
                    break;
                case "CENSORED":
                    SetWeapon();
                    break;
                case "The Smile":
                    SetWeapon();
                    break;
                case "Da Capo":
                    SetWeapon();
                    break;
                case "Adoration":
                    SetWeapon();
                    break;
                case "Paradise Lost":
                    SetWeapon();
                    break;
                default:
                    Console.WriteLine("Error: Weapon Not Recognized");
                    break;

                    }
            }

        public static void SetWeapon(string[] inputArray)
        {
            
            WeaponName= inputArray[0];
            WeaponClass = inputArray[1];
            DamageType = inputArray[2];
            MinDam = Convert.ToInt32(inputArray[3]);
            MaxDam = Convert.ToInt32(inputArray[4]);
            Hits = Convert.ToInt32(inputArray[5]);
            SwingSpeed = Convert.ToDouble(inputArray[5]);
            Console.WriteLine($"The weapon you have inputted is {WeaponName} of the {WeaponClass} class.");
            Console.WriteLine($"It does the {DamageType} damage type, dealing between {MinDam} and {MaxDam} per hit, and deals damage {Hits} times per hit.");
                        
        }


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
