using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using AR.Domain;
using System.Threading.Tasks;

namespace AR.Data.Interfaces
{
    public interface IClienteRepository
    {
        IQueryable<Cliente> GetAll();
        Task Add(Cliente entity);
    }
}
