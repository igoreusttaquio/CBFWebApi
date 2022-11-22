using CBFWebApi.Entidades;

namespace CBFWebApi.Servicos
{
    public class TorneioService
    {
        public List<Torneio> _torneios = new List<Torneio>();

        public List<Torneio>? All()
        {
            return _torneios.ToList();
        }

        public bool Crate(Torneio torneio)
        {
            _torneios.Add(torneio);
            return true;
        }

        public Torneio? GetById(int id)
        {
            var response = _torneios.Find(t => t.Id == id);
            if (response == null) return null;
            return response;
        }
    }
}
