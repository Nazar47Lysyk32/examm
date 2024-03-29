﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ConsoleApp18
{
    
    class Mage : Hero
    {
        public Mage(string Name, double Health, double AttackPower, int ResistanceToPhysical, int ResistanceToMagical) :
            base(Name, Health, AttackPower, ResistanceToPhysical, ResistanceToMagical)
        {
        }

        public double Attack(double AttackPower, Attack typeAttack)
        {

            double totallDamage = AttackPower;



            if (CriticalChance() > 80)
            {
                Console.WriteLine("Mage shield 100%");
                Console.WriteLine("Attack on mage end");
                return 0;
            }





            if (typeAttack == ConsoleApp18.Attack.Physical)
            {

                totallDamage -= ResistanceToPhysical;
                if (CriticalChance() > 50)
                {
                    Console.WriteLine("Enemy hit with critical damage");
                    totallDamage *= 1.5;
                }
            }
            else
            {

                totallDamage -= ResistanceToMagical;
                if (CriticalChance() > 50)
                {
                    Console.WriteLine("Enemy hit with critical damage");
                    totallDamage *= 1.5;
                }
            }

            Console.WriteLine("Attack on mage end");
            return totallDamage;
        }
        public int CriticalChance()
        {
            Random random = new Random();
            int rand = random.Next(1, 101);
            return rand;
        }
    }
}
