using RegistroComunitario.Models;
using System.Collections.Generic;

namespace RegistroComunitario.Data
{
    public interface IVecinoRepository
    {
        IEnumerable<Vecino> GetAll();
        void Add(Vecino vecino);
    }
}
