using System.ComponentModel.DataAnnotations;

namespace SistemaGerenciamentoEventos.Models
{
    public class Evento
    {
        public int Id { get; set; }

        [StringLength(80, MinimumLength =5, ErrorMessage = "Nome deve ter entre 5 e 80 caracteres.")]
        [Required(ErrorMessage = "O nome é obrigatório")]
        public string Nome { get; set; }

        [MinLength(10, ErrorMessage = "Descrição deve ter no minimo 10 caracteres.")]
        [Required(ErrorMessage = "Descrição obrigatória!")]
        public string Descricao { get; set; }

        [StringLength(100, MinimumLength = 3, ErrorMessage = "Nome deve ter entre 5 e 80 caracteres.")]
        [Required(ErrorMessage = "O Local é obrigatório")]

        public string Local { get; set; }
        public DateTime DataEvento { get; set; }

        [Range(1, 1000, ErrorMessage = "No mínimo 1 vaga e o max 1000")]
        public int QntdVagas { get; set; }
        public decimal ValorIngresso { get; set; }
    }
}