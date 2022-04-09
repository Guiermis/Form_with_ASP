using System.ComponentModel.DataAnnotations;

namespace SegundoProjetoSemi.Models
{
    public class Resposta
    {
        [Required(ErrorMessage = "Por favor, preencha o nome!")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "E-mail é obrigatório!")]
        public string Email { get; set; }
        [Required(ErrorMessage = "É necessário escolher seu curso!")]
        public string Opcao { get; set; }

    }
}
