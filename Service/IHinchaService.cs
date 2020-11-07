using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiExamenAngulaNet.Entity;

namespace WebApiExamenAngulaNet.Service
{
    public interface IHinchaService
    {
        Task<List<Hincha>> GetAllHinchas();
        Task<Hincha> GetHincha(int id);
        Task<Hincha> CreateHincha(Hincha hincha);
        Task UpdateHincha(Hincha hincha);
        Task DeleteHincha(Hincha hincha);
    }
}
