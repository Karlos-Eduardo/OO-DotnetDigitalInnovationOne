using static System.Console;
using DOTNET_POO.src.Entities;

namespace DOTNET_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight arus = new Knight("Arus", 42,"Knight", 749, 72);
            Ninja ninja = new Ninja("Wedge", 42, "Ninja", 574, 89);
            Wizard whiteWizard = new Wizard("Jessica", 42, "White Wizard", 601, 482);
            Wizard blackWizard = new Wizard("Topapa", 42, "Black Wizard", 385, 641);
            
            WriteLine($@" 

            Informações:

            {arus}
            {ninja}
            {whiteWizard}
            {blackWizard}

            Ataques:

            {arus.Attack()}
            {ninja.Attack()}
            {whiteWizard.Attack(2)}
            {blackWizard.Attack(4)}
            
            ");
        }
    }
}
