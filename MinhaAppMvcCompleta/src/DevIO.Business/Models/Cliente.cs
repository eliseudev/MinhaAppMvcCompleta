using System.ComponentModel.DataAnnotations;


namespace DevIO.Business.Models
{
    public class Cliente
    {
       
        [Required(ErrorMessage ="O Campo {0}, é obrigatório}")]
        [StringLength(100, ErrorMessage ="O Campo {0} deve ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string Nome { get; set; }
        [StringLength(11, ErrorMessage = "O campos {0} precisa ter {1} caracter")]
        public string cpf { get; set; }
        public string rg { get; set; }
        public string Celular { get; set; }
        public string NomePai { get; set; }
        public string NomeMae { get; set; }


    }
}
