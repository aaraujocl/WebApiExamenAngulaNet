using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiExamenAngulaNet.Entity;

namespace WebApiExamenAngulaNet.Service.Implementacion
{
    public class HinchaService: IHinchaService
    {
        private readonly PostDbContext context;

        public HinchaService() => context = new PostDbContext();

        public async Task<Hincha> CreateHincha(Hincha hincha)
        {
           
            try
            {
                context.Hincha.Add(hincha);
                await context.SaveChangesAsync();
            }
            catch (Exception e)
            {
                throw new NotImplementedException();
            }
            return hincha;
        
        }

        public Task DeleteHincha(Hincha hincha)
        {
            throw new NotImplementedException();
        }

        public Task<List<Hincha>> GetAllHinchas()
        {
            throw new NotImplementedException();
        }

        public Task<Hincha> GetHincha(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateHincha(Hincha hincha)
        {
            throw new NotImplementedException();
        }
    }
}
