using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiExamenAngulaNet.Entity;

namespace WebApiExamenAngulaNet.Service.Implementacion
{
    public class EstadioService : IEstadoService
    {
        private readonly PostDbContext context;

        public EstadioService() => context = new PostDbContext();

        public Task CreateEstadio(Estadio estadio)
        {
            throw new NotImplementedException();
        }

        public Task DeleteEstadio(Estadio estadio)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Estadio>> GetAllEstadios()
        {
            List<Estadio> LstEstadios = new List<Estadio>();
            try
            {
                LstEstadios = await context.Estadio.
                    Include(x => x.ControldeEntradas).ToListAsync();
            }
            catch (Exception e)
            {
                throw new NotImplementedException();
            }
            return LstEstadios;
        }

        public Task<Estadio> GetEstadio(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Estadio> UpdateEstadio(Estadio estadio)
        {
            try
            {
                context.Estadio.Update(estadio);
                await context.SaveChangesAsync();
            }
            catch (Exception e)
            {
                throw new NotImplementedException();
            }
            return estadio;
        }

     
    }
}
