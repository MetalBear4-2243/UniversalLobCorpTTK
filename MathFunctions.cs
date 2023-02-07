using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace UniversalLobCorpTTK
{
    public static class MathFunctions
    {
        // attack speed is 0.8 + (Justice / 143) * Base Weapon Swing Speed
        public static double CalculateDPS(int TargetHealth, int Justice, double DamageMult, double SwingSpeed, int MinDamage, int MaxDamage, int Hits, double LevelMult)
        {
            //uses a sample of 3 rolls of the attack to determine an average damage, and then
            //calculates dps based on that damage, and attack speed
            double Damage1 = CalculateDamage(DamageMult, MinDamage, MaxDamage, Hits, LevelMult);
            double Damage2 = CalculateDamage(DamageMult, MinDamage, MaxDamage, Hits, LevelMult);
            double Damage3 = CalculateDamage(DamageMult, MinDamage, MaxDamage, Hits, LevelMult);
            double AverageDamagePerHit = ((Damage1 + Damage2 + Damage3) / 3);

            //getting the hits per second

            double SPS = SwingsPerSecond(Justice, SwingSpeed);

            double DPS = AverageDamagePerHit * SPS;
            return DPS;

        }
         

        public static int TTK(int TargetHealth, double DPS)
        {
            double Health = TargetHealth;
            int time = 0;
            while (Health > 0)
            {
                
                Health -= DPS;

                time++;
            }
            return time;
        }

        public static double Average()
        {

            int TargetHealth = GetInputs.TargetHealth;
            int Justice = GetInputs.Justice;
            double DamageMult = GetInputs.DamageMult;
            double SwingSpeed = GetInputs.SwingSpeed;
            int MinDamage = GetInputs.MinDamage;
            int MaxDamage = GetInputs.MaxDamage;
            int Hits = GetInputs.Hits;
            int AttackingLevel = GetInputs.AttackingLevel;
            int DefendingLevel = GetInputs.DefendingLevel;
            
            
            int i = 0;
            int totalTTK = 0;
            double LevelMult = GetLevelDiffMult(AttackingLevel, DefendingLevel);
            while (i < 3)
            {
                double DPS = CalculateDPS(TargetHealth, Justice, DamageMult, SwingSpeed, MinDamage, MaxDamage, Hits, LevelMult);
                int TempTTK = TTK(TargetHealth, DPS);
                totalTTK += TempTTK;
                i++;
            }
            double Average = totalTTK / 3;
            return Average;
        }

        public static double GetLevelDiffMult(int AttackingLevel, int DefendingLevel) 
        {
            int EndLevel = AttackingLevel - DefendingLevel;
            double LevelMult = 0;
            
            switch (EndLevel)
            {
                case -4:
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

            return LevelMult;
        }

        public static double CalculateDamage(double DamageMult, int MinDamage, int MaxDamage, int Hits, double LevelMult)
        {
            int i = Hits;
            double damage = 0;
            while (i > 0)
            {
                Random r = new Random();
                double rInt = r.Next(MinDamage, MaxDamage);
                double finalRandom = Math.Round(rInt);
                damage += finalRandom;

                i--;

            }
            double FinalDamage = damage * DamageMult * LevelMult;
            return FinalDamage;
        }

        public static double SwingsPerSecond(int Justice, double SwingSpeed)
        {
            double SwingPerSecond = (0.8 + (Justice / 143)) / SwingSpeed;
            return SwingPerSecond;
        }


    }
}





