using System.Drawing;
using HeroLibrary;

namespace UserInterface
{
    internal class OptionsFunctionalities
    {
        CodeFunctionalities getCodeFunctionalities = new CodeFunctionalities(); //Instância de CodeFunctionalities.
        int value;

        /// <summary>
        /// Criar um personaaágem Herói através da instância hero.
        /// </summary>
        /// <param name="hero"> Instância do Record Hero. </param>
        public void CreateHero(Hero hero)
        {
            Console.Clear(); //Limpar o Console.

            Program.ColorText("Enter your ", ConsoleColor.Yellow);
            Program.ColorText("Hero's ", ConsoleColor.Blue);
            Program.ColorText("Name", ConsoleColor.Green);
            Program.ColorText(":\n", ConsoleColor.Yellow);
            Program.ColorText(">> ", ConsoleColor.DarkGreen);
            hero.Name = Console.ReadLine()!; //Ler o Nome do Herói.

            Program.ColorText("\nEnter your ", ConsoleColor.Yellow);
            Program.ColorText("Hero's ", ConsoleColor.Blue);
            Program.ColorText("Class", ConsoleColor.Green);
            Program.ColorText(":\n", ConsoleColor.Yellow);
            Program.ColorText(">> ", ConsoleColor.DarkGreen);
            hero.Class = Console.ReadLine()!; //Ler a Classe do Herói.

            Program.ColorText("\nEnter your ", ConsoleColor.Yellow);
            Program.ColorText("Hero's ", ConsoleColor.Blue);
            Program.ColorText("Level", ConsoleColor.Green);
            Program.ColorText(":\n", ConsoleColor.Yellow);
            Program.ColorText(">> ", ConsoleColor.DarkGreen);
            if (int.TryParse(Console.ReadLine()!, out value)) { hero.Level = value; }
            else { Program.ColorText("Invalid Input Value!\n", ConsoleColor.Red); } //Ler o Nível do Herói.

            Program.ColorText("\nEnter your ", ConsoleColor.Yellow);
            Program.ColorText("Hero's ", ConsoleColor.Blue);
            Program.ColorText("Special Attack(s)", ConsoleColor.Green);
            Program.ColorText(":\n", ConsoleColor.Yellow);
            Program.ColorText(">> ", ConsoleColor.DarkGreen);
            hero.SpecialAttack = Console.ReadLine()!; //Ler o Ataque Especial do Herói.

            Program.ColorText("\n===================================\n\n", ConsoleColor.Cyan);
            
            getCodeFunctionalities.Validate(hero);

            Program.ContinueCode();
        }

        /// <summary>
        /// Listar todos os Heróis criados.
        /// </summary>
        public void SeeAll()
        {
            Console.Clear();

            Program.ColorText("=== Current ", ConsoleColor.Cyan);
            Program.ColorText("Heroes ===\n\n", ConsoleColor.Blue);

            foreach (Hero hero in CodeFunctionalities.heroes) //Listar todos os
            {
                Program.ColorText("Hero: ", ConsoleColor.Blue);
                Program.ColorText($"{hero.Name}", ConsoleColor.Green);
                Program.ColorText(", Lvl: ", ConsoleColor.Blue);
                Program.ColorText($"{hero.Level}\n", ConsoleColor.Green);
                Program.ColorText($"{hero.Class}", ConsoleColor.Green);
                Program.ColorText(": ", ConsoleColor.Blue);
                Program.ColorText($"{hero.SpecialAttack}\n", ConsoleColor.Green);

                Program.ColorText($"\n==============================\n", ConsoleColor.Cyan);
            }

            Program.ContinueCode();
        }
    }
}
