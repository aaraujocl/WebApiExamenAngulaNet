using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiExamenAngulaNet.Entity;

namespace WebApiExamenAngulaNet.Service.Implementacion
{
    public class EntradaService: IEntradaService
    {
        private readonly PostDbContext context;

        public EntradaService() => context = new PostDbContext();

        public Task CreateEntrada(Entrada entrada)
        {
            throw new NotImplementedException();
        }

        public Task DeleteEntrada(Entrada entrada)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Entrada>> GetAllEntrada()
        {
            List<Entrada> LstEntrada = new List<Entrada>();
            try
            {
                LstEntrada = await context.Entrada.ToListAsync();
            }
            catch (Exception e)
            {
                throw new NotImplementedException();
            }
            return LstEntrada;
        }

        public Task<Entrada> GetEntrada(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateEntrada(Entrada entrada)
        {
            throw new NotImplementedException();
        }
    }
}
