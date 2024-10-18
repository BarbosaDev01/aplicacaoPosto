using System.ComponentModel.DataAnnotations;

namespace aplicacao1.Models
{
    public class Carro
    {
        [Key]
        public int IdCarro { get; set; }
        [Required]
        public string modeloCarro { get; set; }
        [Required]
        public double kwCarro { get; set; }
        [Required]
        public int IdUsuario { get; set; }
        [Required]
        public Usuario Usuario { get; set; }
    }
}
