using System.ComponentModel.DataAnnotations;

namespace HeroLibrary
{
    public class CodeFunctionalities
    {
        public static List<Hero> heroes = new List<Hero>(); //Lista para guardar os Heróis criados.

        /// <summary>
        /// Valida os valores digitádos.
        /// </summary>
        /// <param name="hero"> Instância da Classe. </param>
        public void Validate(Hero hero)
        {
            var context = new ValidationContext(hero); //Verifica as Propriedádes de 'Hero'.
            var result = new List<ValidationResult>(); //Mostra o resultado da validação.

            bool isValid = Validator.TryValidateObject(hero, context, result, true); //Valida seus valores.

            if (!isValid) //Caso as Própriedades não sejam Válidas:
            {
                ColorText("=== Error List ===\n\n", ConsoleColor.DarkRed);

                foreach (var ValidateResult in result) //Lista o que há de errado.
                {
                    ColorText($"• {ValidateResult.ErrorMessage}\n", ConsoleColor.Red); //Mostra as menságens de erro do DataAnnotation.

                    ColorText("\n=============================\n", ConsoleColor.Cyan);
                }
            }
            else //Caso sejá válido, os valôres digitádos são mostrados.
            {
                heroes.Add(hero); //Adicionar a Lista.

                ColorText("Hero: ", ConsoleColor.Blue);
                ColorText($"{hero.Name}", ConsoleColor.Green);
                ColorText(", Lvl: ", ConsoleColor.Blue);
                ColorText($"{hero.Level}\n", ConsoleColor.Green);
                ColorText($"{hero.Class}", ConsoleColor.Green);
                ColorText(": ", ConsoleColor.Blue);
                ColorText($"{hero.SpecialAttack}", ConsoleColor.Green);
            }
        }

        /// <summary>
        /// Colorir um Print
        /// </summary>
        /// <param name="print"> String que o será colorida. </param>
        /// <param name="color"> Cor que será aplicada. </param>
        static void ColorText(string print, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.Write(print);
            Console.ResetColor();
        }
    }
}
