using System.ComponentModel.DataAnnotations;

namespace LovePet.Models
{
    public class Animal
    {
        [Key]
        public int AnimalId { get; set; }

        [Required(ErrorMessage = "O nome do animal deve ser informado")]
        [Display(Name = "Nome do animal")]
        [StringLength(80, MinimumLength = 10, ErrorMessage = "O {0} tamanho minimo é maximo é {1} caracteres e no maximo {2} caracteres")]
        public string? Nome { get; set; }

        [Required(ErrorMessage = "A raça do animal deve ser informado")]
        [Display(Name = "Raça do animal")]
        [StringLength(80, MinimumLength = 10, ErrorMessage = "O {0} tamanho minimo é maximo é {1} caracteres e no maximo {2} caracteres")]
        public string? Raca { get; set; }


        [Display(Name = "Foto do animal")]
        [StringLength(250, MinimumLength = 10, ErrorMessage = "A {0} tamanho minimo é maximo é {1} caracteres e no maximo {2} caracteres")]
        public string? ImagemUrl { get; set; }
    }
}