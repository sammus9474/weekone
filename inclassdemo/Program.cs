using studentLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace inclassdemo
{
    class Program
    {
        static void Main(string[] args)
        {
            hunter Vexaliah = new hunter();
            mage Caleb = new mage();

            Vexaliah.name = "Vex'aliah";
            Vexaliah.race = "Half Elf";
            Vexaliah.bow = "Blazing Bowstring/+1 Longbow";
            Vexaliah.quiver = "standard Quiver";

            Caleb.name = "Caleb WidowGhast";
            Caleb.race = "Human";
            Caleb.wand = "None";
            Caleb.spellBook = "Transmutation";

            Console.WriteLine(Vexaliah);
            Console.WriteLine(Caleb);
        }
    }
}
