using System.ComponentModel.DataAnnotations;

namespace HeroLibrary
{
    public record Hero
    {
        [Required(ErrorMessage = "Name must be provided!")]
        public string Name { get; set; } = string.Empty; //Guardar o nome do Herói.

        [Required(ErrorMessage = "Provide a Class for your Hero!")]
        public string Class { get; set; } = string.Empty; //Guardar a Classe do herói.

        [Required(ErrorMessage = "You must provide a Level to your hero!")]
        [Range(1, 99, ErrorMessage = "Length must be between 1 and 99!")]
        public int Level { get; set; } //Guardar o Nível do Herói.

        [Required(ErrorMessage = "Provide a random Special Attack for your Hero.")]
        public string SpecialAttack { get; set; } = string.Empty; //Guardar o Golpe Especial do Herói.
    }
}
