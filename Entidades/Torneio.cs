namespace CBFWebApi.Entidades
{
    public class Partida
    {
        public int Id { get; set; }
        public int Inicio { get; set; }
        public int Gols { get; set; } = 0;
        public int Intervalo { get; set; }
        public int Acrescimo { get; set; }
        public List<int>? Substituicao { get; set; }
        public List<int>? Advertencias { get; set; }
        public int Fim { get; set; }
        public Time? T1 { get; set; }
        public Time? T2 { get; set; }
    }

    public class Torneio
    {
        public int Id { get; set; }
        public List<Time> Times { get; set; }
        public List<Partida> Partidas { get; set; }

        public bool CriarPartida(Time t1, Time t2, int inicio, int id)
        {

            Partidas.Add(new Partida
            {
                T1 = t1,
                T2 = t2,
                Inicio = inicio,
                Id = id
            });
            return true;
        }

    }
}
