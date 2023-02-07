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
        public static string WeaponName = "";
        public static string WeaponClass = "";
        public static int AttackingLevel = 0;
        public static int DefendingLevel = 0;
        public static string DamageType = "";

        
        public static double RedMult = 0;
        public static double WhiteMult = 0;
        public static double BlackMult = 0;
        public static double PaleMult = 0;
        public static double DamageMult = 0;

        public static double SwingSpeed = 0;
        public static int MinDamage = 0;
        public static int MaxDamage = 0;
        public static int Hits = 0;

        public static void SetArray()
        {
            Console.WriteLine("Input the Weapon of the Employee");
            string SelectedWeapon = GenericFunctions.GetName();
            
            switch (SelectedWeapon)
            {
                case "Penitence":
                    SetWeapon(WeaponArrays.Penitence);
                    break;
                case "Soda":
                    SetWeapon(WeaponArrays.Soda);
                    break;
                case "Tough":
                    SetWeapon(WeaponArrays.Tough);
                    break;
                case "Wingbeat":
                    SetWeapon(WeaponArrays.Wingbeat);
                    break;
                case "Pink":
                    SetWeapon(WeaponArrays.Pink);
                    break;
                case "Training Standard EGO":
                    SetWeapon(WeaponArrays.TrainingStandardEGO);
                    break;
                case "Fourth Match Flame":
                    SetWeapon(WeaponArrays.FourthMatchFlame);
                    break;
                case "Loneliness":
                    SetWeapon(WeaponArrays.Loneliness);
                    break;
                case "Screaming Wedge":
                    SetWeapon(WeaponArrays.ScreamingWedge);
                    break;
                case "Red Eyes":
                    SetWeapon(WeaponArrays.RedEyes);
                    break;
                case "Horn":
                    SetWeapon(WeaponArrays.Horn);
                    break;
                case "Wrist Cutter":
                    SetWeapon(WeaponArrays.WristCutter);
                    break;
                case "Regret":
                    SetWeapon(WeaponArrays.Regret);
                    break;
                case "Beak":
                    SetWeapon(WeaponArrays.Beak);
                    break;
                case "Somewhere Spear":
                    SetWeapon(WeaponArrays.SomewhereSpear);
                    break;
                case "Life for the Daredevil":
                    SetWeapon(WeaponArrays.LifefortheDaredevil);
                    break;
                case "Lantern":
                    SetWeapon(WeaponArrays.Lantern);
                    break;
                case "Today's Expression":
                    SetWeapon(WeaponArrays.TodaysExpression);
                    break;
                case "Rapturous Dream":
                    SetWeapon(WeaponArrays.RapturousDream);
                    break;
                case "Cherry Blossom":
                    SetWeapon(WeaponArrays.CherryBlossom);
                    break;
                case "CUTE!!!":
                    SetWeapon(WeaponArrays.CUTE);
                    break;
                case "Bear Paw":
                    SetWeapon(WeaponArrays.BearPaw);
                    break;
                case "Bloody Desire":
                    SetWeapon(WeaponArrays.BloodyDesire);
                    break;
                case "Crier":
                    SetWeapon(WeaponArrays.Crier);
                    break;
                case "Harmony":
                    SetWeapon(WeaponArrays.Harmony);
                    break;
                case "Logging":
                    SetWeapon(WeaponArrays.Logging);
                    break;
                case "Frost Shard":
                    SetWeapon(WeaponArrays.FrostShard);
                    break;
                case "Grinder Mk4":
                    SetWeapon(WeaponArrays.GrinderMk4);
                    break;
                case "Christmas":
                    SetWeapon(WeaponArrays.Christmas);
                    break;
                case "Galaxy":
                    SetWeapon(WeaponArrays.Galaxy);
                    break;
                case "Laetitia":
                    SetWeapon(WeaponArrays.Laetitia);
                    break;
                case "Magic Bullet":
                    SetWeapon(WeaponArrays.MagicBullet);
                    break;
                case "Gaze":
                    SetWeapon(WeaponArrays.Gaze);
                    break;
                case "Pleasure":
                    SetWeapon(WeaponArrays.Pleasure);
                    break;
                case "Harvest":
                    SetWeapon(WeaponArrays.Harvest);
                    break;
                case "Justitia":
                    SetWeapon(WeaponArrays.Justitia);
                    break;
                case "Green Stem":
                    SetWeapon(WeaponArrays.GreenStem);
                    break;
                case "Lamp":
                    SetWeapon(WeaponArrays.Lamp);
                    break;
                case "Blue Scar":
                    SetWeapon(WeaponArrays.BlueScar);
                    break;
                case "Crimson Scar":
                    SetWeapon(WeaponArrays.CrimsonScar);
                    break;
                case "Black Swan":
                    SetWeapon(WeaponArrays.BlackSwan);
                    break;
                case "Gold Rush":
                    SetWeapon(WeaponArrays.GoldRush);
                    break;
                case "Ecstasy":
                    SetWeapon(WeaponArrays.Ecstasy);
                    break;
                case "Diffraction":
                    SetWeapon(WeaponArrays.Diffraction);
                    break;
                case "Amita":
                    SetWeapon(WeaponArrays.Amita);
                    break;
                case "A Sword Sharpened By Tears":
                    SetWeapon(WeaponArrays.ASwordSharpenedByTears);
                    break;
                case "Heaven":
                    SetWeapon(WeaponArrays.Heaven);
                    break;
                case "Hornet":
                    SetWeapon(WeaponArrays.Hornet);
                    break;
                case "Hypocrisy":
                    SetWeapon(WeaponArrays.Hypocrisy);
                    break;
                case "Reverberation":
                    SetWeapon(WeaponArrays.Reverberation);
                    break;
                case "ShedSkin":
                    SetWeapon(WeaponArrays.ShedSkin);
                    break;
                case "Discord":
                    SetWeapon(WeaponArrays.Discord);
                    break;
                case "Feather Of Honor":
                    SetWeapon(WeaponArrays.FeatherOfHonor);
                    break;
                case "Spore":
                    SetWeapon(WeaponArrays.Spore);
                    break;
                case "Moonlight":
                    SetWeapon(WeaponArrays.Moonlight);
                    break;
                case "Mimicry":
                    SetWeapon(WeaponArrays.Mimicry);
                    break;
                case "Sound Of A Star":
                    SetWeapon(WeaponArrays.SoundOfAStar);
                    break;
                case "CENSORED":
                    SetWeapon(WeaponArrays.CENSORED);
                    break;
                case "The Smile":
                    SetWeapon(WeaponArrays.TheSmile);
                    break;
                case "Da Capo":
                    SetWeapon(WeaponArrays.DaCapo);
                    break;
                case "Adoration":
                    SetWeapon(WeaponArrays.Adoration);
                    break;
                case "Paradise Lost":
                    SetWeapon(WeaponArrays.ParadiseLost);
                    break;
                default:
                    Console.WriteLine("Error: Weapon Not Recognized. Try Again:");
                    SetArray();
                    break;

            }
        }

        public static void SetWeapon(string[] inputArray)
        {

            WeaponName = inputArray[0];
            WeaponClass = inputArray[1];
            DamageType = inputArray[2];
            MinDamage = Convert.ToInt32(inputArray[3]);
            MaxDamage = Convert.ToInt32(inputArray[4]);
            Hits = Convert.ToInt32(inputArray[5]);
            SwingSpeed = Convert.ToDouble(inputArray[5]);
            Console.WriteLine($"The weapon you have inputted is {WeaponName} of the {WeaponClass} class.");
            Console.WriteLine($"It does the {DamageType} damage type, dealing between {MinDamage} and {MaxDamage} per hit, and deals damage {Hits} times per hit.");
            Justice = GetJustice();

        }


        public static void AssignAbnoValues()
        {
            Console.WriteLine("Input the Target Health Stat:");

            string HealthInput = GenericFunctions.GetName();
            TargetHealth = Convert.ToInt32(HealthInput);

            GetDamageMult();

            SetDamageType();
            
        }

        public static int GetJustice()
        {
            Console.WriteLine("Input the Employee Justice Stat:");
            string JusticeInput = GenericFunctions.GetName();
            int Justice = Convert.ToInt32(JusticeInput);
            return Justice;
        }
        public static void GetDamageMult()
        {
            string DamageMultInput = "";
            double DamageMultiple = 0;


            Console.WriteLine("Input the Red Damage Multiplier Stat:");
            DamageMultInput = GenericFunctions.GetName();
            DamageMultiple = Convert.ToDouble(DamageMultInput);
            RedMult= Convert.ToDouble(DamageMultiple);

            Console.WriteLine("Input the White Damage Multiplier Stat:");
            DamageMultInput = GenericFunctions.GetName();
            DamageMultiple = Convert.ToDouble(DamageMultInput);
            WhiteMult = Convert.ToDouble(DamageMultiple);

            Console.WriteLine("Input the Black Damage Multiplier Stat:");
            DamageMultInput = GenericFunctions.GetName();
            DamageMultiple = Convert.ToDouble(DamageMultInput);
            BlackMult = Convert.ToDouble(DamageMultiple);

            Console.WriteLine("Input the Pale Damage Multiplier Stat:");
            DamageMultInput = GenericFunctions.GetName();
            DamageMultiple = Convert.ToDouble(DamageMultInput);
            PaleMult = Convert.ToDouble(DamageMultiple);
        }

        public static void SetDamageType()
        {
            switch(DamageType)
            {
                case "Red":
                    DamageMult = RedMult; 
                    break;
                case "White":
                    DamageMult = WhiteMult;
                    break;
                case "Black":
                    DamageMult = BlackMult;
                    break;
                case "Pale":
                    DamageMult = PaleMult;
                    break;
                default:
                    Console.WriteLine("Damage Type Could not be Identified.");
                    GenericFunctions.PauseForInput();
                    break;
            }
        }
    }
}