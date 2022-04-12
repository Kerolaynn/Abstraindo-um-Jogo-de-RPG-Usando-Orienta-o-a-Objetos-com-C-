using System;
using rpg.src.Entites;
namespace rpg // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Knight arus = new Knight("Arus", 23, "Knight", 749, 72);
            Wizard whiteWizard = new Wizard("Jennica" , 23," White Wizard", 601, 482);
            Wizard blackWizard = new Wizard("Topapa" , 42," Black Wizard", 385, 641);
            Ninja ninja = new Ninja("Wedge" , 42," Ninja", 574, 89);

            Console.WriteLine(whiteWizard.Attack(1));
            Console.WriteLine(blackWizard.Attack(1));
            Console.WriteLine(arus.Attack());
            Console.WriteLine(ninja.Attack(1));

            Console.WriteLine(arus.ToString());
            Console.WriteLine(whiteWizard.ToString());
            Console.WriteLine(blackWizard.ToString());
            Console.WriteLine(ninja.ToString());
        }
    }
}