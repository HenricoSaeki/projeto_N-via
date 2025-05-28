using System.ComponentModel.DataAnnotations;

namespace testeMVC.Models
{
    public class Pessoa
    {
        [Display(Name = "Codigo do Cliente")]
        [Display(Name = "Nome do Cliente")]
        public int? PessoaId { get; set; }
        public string? Nome { get; set; }
        public string? Email { get; set; }
    }
}
