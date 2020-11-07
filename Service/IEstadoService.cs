using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiExamenAngulaNet.Entity;

namespace WebApiExamenAngulaNet.Service
{
    public interface IEstadoService
    {
        Task<List<Estadio>> GetAllEstadios();
        Task<Estadio> GetEstadio(int id);
        Task CreateEstadio(Estadio estadio);
        Task<Estadio> UpdateEstadio(Estadio estadio);
        Task DeleteEstadio(Estadio estadio);
    }
}
