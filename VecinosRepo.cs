using RegistroComunitario.Models;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;

namespace RegistroComunitario.Data
{
    public class VecinosRepo
    {
        private readonly ConcurrentDictionary<int, Vecino> _lista = new();
        private int _nextId = 0;

        public IEnumerable<Vecino> GetAll() => _lista.Values.OrderBy(v => v.Id);

        public void Add(Vecino vecino)
        {
            var id = System.Threading.Interlocked.Increment(ref _nextId);
            vecino.Id = id;
            _lista.TryAdd(vecino.Id, vecino);
        }
    }
}
