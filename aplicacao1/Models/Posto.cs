namespace aplicacao1.Models
{
    public class Posto:Localizacao
    {
        public int IdPosto { get; set; }
        public string TipoCarga { get; set; }
        public string ValorPino { get; set; }
        public double potenciaPosto { get; set; }
    }
}
