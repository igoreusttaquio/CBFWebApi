namespace CBFWebApi.Entidades
{
    public class Torneio
    {
        public int Id { get; set; }
        public List<Time> Times { get; set; }
        public List<Tuple<Time, Time>> Partidas { get; set; }

        public bool CriarPartida(Time t1, Time t2)
        {
            var Partida = Tuple.Create(t1, t2);
            Partidas.Add(Partida);
            return true;
        }

    }
}
