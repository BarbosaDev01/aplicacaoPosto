using System.ComponentModel.DataAnnotations;

namespace aplicacao1.Models
{
    public class Usuario
    {
        [Key]
        public int IdUsuario { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string email { get; set; }
    }
}

