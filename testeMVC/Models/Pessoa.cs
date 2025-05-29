using System.ComponentModel.DataAnnotations;

namespace testeMVC.Models
{
    public class Pessoa
    {
        [Display(Name = "Codigo do Cliente")]
        public int? PessoaId { get; set; }
        [Display(Name = "Nome do Cliente")]
        public string? Nome { get; set; }
        [Display(Name = "Email do Cliente")]
        public string? Email { get; set; }
    }
}
