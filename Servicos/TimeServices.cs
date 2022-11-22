using CBFWebApi.Entidades;

namespace CBFWebApi.Servicos
{
    public class TimeServices
    {
        private List<Time> _times = new List<Time>();

        public List<Time> All()
        {
            return _times.ToList();
        }

        public bool Create(Time time)
        {
            _times.Add(time);
            return true;
        }

        public bool Update(Time timeUpdate)
        {
            var time = _times.FirstOrDefault(t => t.Id == timeUpdate.Id);
            if (time == null) return false;
            time.Id = timeUpdate.Id;
            time.Nome = timeUpdate.Nome;
            time.Localidade = timeUpdate.Localidade;

            _times.Remove(time);
            _times.Add(time);
            return true;
        }

        public bool Delete(Time time)
        {
            if (!_times.Any(t => t.Id == time.Id)) return false;
            _times.Remove(time);
            return true;

        }

        public Time? GetById(int id)
        {
            var time = _times.Find(t => t.Id == id);
            return time;
        }
    }
}
