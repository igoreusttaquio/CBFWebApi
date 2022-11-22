using CBFWebApi.Entidades;

namespace CBFWebApi.Servicos
{
    public class JogadorService
    {
        private List<Jogador> _jogadores = new List<Jogador>();
        public bool Create(Jogador jogador)
        {
            _jogadores.Add(jogador);
            return true;
        }

        public bool Update(Jogador jogadorUpdate)
        {
            var jogador = _jogadores.FirstOrDefault(j => j.Id == jogadorUpdate.Id);
            if (jogador == null) return false;
            jogador.Id = jogadorUpdate.Id;
            jogador.Nome = jogadorUpdate.Nome;
            jogador.Time = jogadorUpdate.Time;
            jogador.Time = jogadorUpdate.Time;

            _jogadores.Remove(jogador);
            _jogadores.Add(jogador);
            return true;
        }

        public bool Delete(Jogador jogador)
        {
            if (!_jogadores.Any(j => j.Id == jogador.Id)) return false;
            _jogadores.Remove(jogador);
            return true;

        }

        public Jogador? GetById(int id)
        {
            var jogador = _jogadores.Find(j => j.Id == id);
            return jogador;
        }

    }
}
