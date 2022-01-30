using System;
using projeto_rpg.src.Entities;

namespace projeto_rpg
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Knight  Arus = new Knight("Arus", 23, "Knigth");
            Wizard Jennica = new Wizard("Jennica", 23, "WhiteWizard");
            
            Console.WriteLine(Arus.Attack());
            Console.WriteLine(Jennica.Attack(1));
            Console.WriteLine(Jennica.Attack(7));
            
        
        }
    }

}