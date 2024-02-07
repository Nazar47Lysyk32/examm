using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    
    internal class Hero
    {
        public string Name { get; set; }
        public double Health { get; set; }
        public double AttackPower { get; set; }
        public int ResistanceToPhysical { get; set; }
        public int ResistanceToMagical { get; set; }


        public Hero(string Name, double Health, double AttackPower, int ResistanceToPhysical, int ResistanceToMagical)
        {
            this.Name = Name;
            this.Health = Health;
            this.AttackPower = AttackPower;
            this.ResistanceToPhysical = ResistanceToPhysical;
            this.ResistanceToMagical = ResistanceToMagical;

        }


    }
}