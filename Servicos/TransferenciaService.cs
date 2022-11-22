using CBFWebApi.Entidades;

namespace CBFWebApi.Servicos
{
    public class TransferenciaService
    {
        private List<Transferencia> _transferencias = new List<Transferencia>();

        public List<Transferencia> All()
        {
            return _transferencias.ToList();
        }
        public bool Create(Transferencia transferencia)
        {
            _transferencias.Add(transferencia);
            return true;
        }

        public bool Update(Transferencia transferenciaUpdate)
        {
            var transferencia = _transferencias.FirstOrDefault(t => t.Id == transferenciaUpdate.Id);
            if (transferencia == null) return false;
            transferencia.Id = transferenciaUpdate.Id;
            transferencia.TimeOrigem = transferenciaUpdate.TimeOrigem;
            transferencia.TimeDestino = transferenciaUpdate.TimeDestino;

            _transferencias.Remove(transferencia);
            _transferencias.Add(transferencia);
            return true;
        }

        public bool Delete(Transferencia transferencia)
        {
            if (!_transferencias.Any(t => t.Id == transferencia.Id)) return false;
            _transferencias.Remove(transferencia);
            return true;

        }

        public Transferencia? GetById(int id)
        {
            var transferencia = _transferencias.Find(t => t.Id == id);
            return transferencia;
        }
    }
}
