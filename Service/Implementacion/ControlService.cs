using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiExamenAngulaNet.Entity;

namespace WebApiExamenAngulaNet.Service.Implementacion
{
    public class ControlService : IControlService
    {
        private readonly PostDbContext context;

        public ControlService() => context = new PostDbContext();

        public async Task<ControlEntrada> CreateControlEntrada(ControlEntrada ControlEntrada)
        {
            try
            {
                context.ControlEntrada.Add(ControlEntrada);
                await context.SaveChangesAsync();
            }
            catch (Exception e)
            {
                throw new NotImplementedException();
            }
            return ControlEntrada;
        }

        public Task DeleteControlEntrada(ControlEntrada ControlEntrada)
        {
            throw new NotImplementedException();
        }

        public Task<List<ControlEntrada>> GetAllControlEntrada()
        {
            throw new NotImplementedException();
        }

        public Task<ControlEntrada> GetControlEntrada(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateControlEntrada(ControlEntrada ControlEntrada)
        {
            throw new NotImplementedException();
        }

      
    }
}
