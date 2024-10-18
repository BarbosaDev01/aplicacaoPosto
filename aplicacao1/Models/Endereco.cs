using System.ComponentModel.DataAnnotations;

namespace aplicacao1.Models
{
    public class Endereco
    {
        [Key]
        public int IdEndereco { get; set; }
        [Required]
        public string rua { get; set; }
        [Required]
        public string numero { get; set; }
        [Required]
        public string logradouro { get; set; }
        [Required]
        public string bairro { get; set; }
        [Required]
        public string latitude { get; set; }
        [Required]
        public string longitude { get; set; }
    }
}
