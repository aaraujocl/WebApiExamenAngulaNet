using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiExamenAngulaNet.Entity
{
    public class PostDbContext : DbContext
    {
        public PostDbContext()
        {
        }

        //Constructor con parametros para la configuracion
        public PostDbContext(DbContextOptions options)
            : base(options)
        {
        }

        //Sobreescribimos el metodo OnConfiguring para hacer los ajustes que queramos en caso de
        //llamar al constructor sin parametros
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //En caso de que el contexto no este configurado, lo configuramos mediante la cadena de conexion
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=bdkuberneteangular;User ID=sa;Password=123diego456*;MultipleActiveResultSets=True");
            }
        }

        //Tablas de datos
        public virtual DbSet<Estadio> Estadio { get; set; }
        public virtual DbSet<Hincha> Hincha { get; set; }
        public virtual DbSet<Entrada> Entrada { get; set; }
        public virtual DbSet<ControlEntrada> ControlEntrada { get; set; }
    }
}
