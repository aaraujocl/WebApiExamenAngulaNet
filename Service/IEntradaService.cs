using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiExamenAngulaNet.Entity;

namespace WebApiExamenAngulaNet.Service
{
    public interface IEntradaService
    {
        Task<List<Entrada>> GetAllEntrada();
        Task<Entrada> GetEntrada(int id);
        Task CreateEntrada(Entrada entrada);
        Task UpdateEntrada(Entrada entrada);
        Task DeleteEntrada(Entrada entrada);
    }
}
