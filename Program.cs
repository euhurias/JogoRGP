using JogoRPG.SRC.Entities;
using static System.Console;


namespace JogoRPG
{
    public class Program
    {

        
        public static void Main(string[] args)
        {
            Hero hero = new Hero("Arus", 23, "Knight");
            Wizard wizard = new Wizard("jennica", 23, "White Wizard");
            
            //WriteLine(hero.Attack());
            WriteLine(wizard.Attack(1));
        }
    }
}
