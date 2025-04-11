using HeroLibrary;

namespace UserInterface
{
    internal class Program
    {
        static OptionsFunctionalities option = new OptionsFunctionalities(); //Instância da Classe 'OptionFunctionalities'.
        static Hero hero = new Hero(); //Instância do Record 'Hero'.

        static void Main(string[] args)
        {
            bool isRunning = true; //Iniciar/Finalizar Loop.

            ColorText("Welcome to ", ConsoleColor.Cyan);
            ColorText("My Hero's Aventure", ConsoleColor.Green);
            ColorText("!\n\n", ConsoleColor.Cyan);
            ColorText("We present you a few Options. Please, feel free to select any of these!", ConsoleColor.Cyan);

            while (isRunning) //Início do Loop.
            {
                ColorText("\n\n1 - Create a Hero\n", ConsoleColor.Yellow);
                ColorText("2 - See all your Heroes\n", ConsoleColor.Yellow);
                ColorText("3 - Exit program...\n\n", ConsoleColor.Yellow);
                ColorText("Type the desired ", ConsoleColor.Cyan);
                ColorText("Option", ConsoleColor.Yellow);
                ColorText(":\n", ConsoleColor.Cyan);
                ColorText(">> ", ConsoleColor.DarkGreen);
                string response = Console.ReadLine()!; //Recebe a Opção escolhida pelo Usuário.

                switch (response)
                {
                    case "1": option.CreateHero(hero); break; //Criar um Herói.
                    case "2": option.SeeAll(); break; //Ver Heróis criados.
                    case "3": //Finalizar Loop.
                        isRunning = false;
                        ColorText("\nTerminating program", ConsoleColor.Yellow);
                        LoadingAnimation(".", ConsoleColor.Yellow, 4, 1000);
                        break;
                    default: //Caso o Usuário não selecione nenhuma das opções, uma mensagem de erro aparece.
                        Console.Clear();
                        ColorText("Error: ", ConsoleColor.DarkRed);
                        ColorText("Invalid Input Option!", ConsoleColor.Red);                      
                        break;
                }
            }

            Console.Clear();
            ColorText("Program Terminated...\n\nThanks for Joining us!\n", ConsoleColor.DarkYellow);
        }

        /// <summary>
        /// Colorir um Print
        /// </summary>
        /// <param name="print"> String que o será colorida. </param>
        /// <param name="color"> Cor que será aplicada. </param>
        public static void ColorText(string print, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.Write(print);
            Console.ResetColor(); //Retorna a cor ao normal(branco, padrão do Console).
        }

        /// <summary>
        /// Animar um Print/String.
        /// </summary>
        /// <param name="text"> Texto que irá ser animado. </param>
        /// <param name="color"> Cor do Texto. </param>
        /// <param name="textAmount"> Quantidade de veses que essa Strinf deverá aparecer. </param>
        /// <param name="threadTime"> Tempo para que cada string apareça(1000 = 1 segundo). </param>
        public static void LoadingAnimation(string text, ConsoleColor color, int textAmount, int threadTime)
        {
            for (int i = 0; i < textAmount; i++)
            {
                ColorText(text, color);
                Thread.Sleep(threadTime);
            }
        }

        /// <summary>
        /// Resposta a um ReadKey();
        /// </summary>
        public static void ContinueCode()
        {
            ColorText("\n\nPress any ", ConsoleColor.Cyan);
            ColorText("Key ", ConsoleColor.Yellow);
            ColorText("to continue.", ConsoleColor.Cyan);

            LoadingAnimation(".", ConsoleColor.Cyan, 3, 1000);
            Console.ReadKey();
            Console.Clear();
        }
    }
}