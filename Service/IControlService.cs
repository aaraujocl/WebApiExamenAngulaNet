using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiExamenAngulaNet.Entity;

namespace WebApiExamenAngulaNet.Service
{
    public interface IControlService
    {
        Task<List<ControlEntrada>> GetAllControlEntrada();
        Task<ControlEntrada> GetControlEntrada(int id);
        Task<ControlEntrada> CreateControlEntrada(ControlEntrada ControlEntrada);
        Task UpdateControlEntrada(ControlEntrada ControlEntrada);
        Task DeleteControlEntrada(ControlEntrada ControlEntrada);
    }
}
