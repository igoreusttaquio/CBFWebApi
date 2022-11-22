namespace CBFWebApi.Entidades
{
    public class Transferencia
    {
        public int Id { get; set; }
        public Jogador? Jogador { get; set; }
        public Time? TimeOrigem { get; set; }
        public Time? TimeDestino { get; set; }
        public DateTime? Data { get; set; }
        public Decimal? Valor { get; set; }
    }
}
