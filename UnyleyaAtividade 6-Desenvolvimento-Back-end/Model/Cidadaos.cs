using System.ComponentModel.DataAnnotations;

namespace UnyleyaAtividade_6_Desenvolvimento_Back_end.Model
{
    public class Cidadaos
    {
        
        [Required(ErrorMessage = "Todos os campos são obrigatórios!")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Todos os campos são obrigatórios!")]
        public string Cpf { get; set; }

        [Required(ErrorMessage = "Todos os campos são obrigatórios!")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Todos os campos são obrigatórios!")]
        public string Endereco { get; set; }

        [Required(ErrorMessage = "Todos os campos são obrigatórios!")]
        public string Sexo { get; set; }

    }
}
