using System.ComponentModel.DataAnnotations;

namespace PostgreSQL_with_.NET_Core_8._0.Models
{
    public class estudante
    {
        [Key]
        public int Id { get; set; }

        public string Nome { get; set; } = null!;

        public string Sobrenome { get; set; } = null!;

        public string NomeCompleto => $"{Nome} {Sobrenome}"; 

        public string Email { get; set; } = null!;

        public string Telefone { get; set; } 
        public string Endereco { get; set; } = null!;



    }
}
