using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Compiler.Domain.Entities.Tasks
{
    public class Kata
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Название")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Описание")]
        public string Description { get; set; }

        [Display(Name = "Начальный код")]
        public string InitialCode { get; set; } = @"public static int method()
{
    //write ur code here
}";


        public string Input { get; set; } = "";

        public string Output { get; set; } = "";


        [Required]
        [Display(Name = "Язык программирования")]
        public int LanguageId { get; set; }
        public ProgrammingLanguage Language { get; set; }

        

        [Required]
        [Display(Name = "Входные данные")]
        [NotMapped]
        public string[] InputData
        {
            set => Input = string.Join(';', value);
            get => Input.Split(';');
        }

        [Required]
        [Display(Name = "Выходные данные")]
        [NotMapped]
        public string[] OutputData
        {
            set => Output = string.Join(';', value);
            get => Output.Split(';');
        }
    }
}
