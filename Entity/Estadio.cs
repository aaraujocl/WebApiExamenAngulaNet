using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiExamenAngulaNet.Entity
{
    public class Estadio
    {
        public Estadio()
        {
            ControldeEntradas = new HashSet<ControlEntrada>();
        }

        [Key]
        public int IdEstadio { get; set; }
        public string Nombre { get; set; }
        public int CapacidadTotal { get; set; }
        public int Porcentaje { get; set; }
        public int CapacidadPermitida { get; set; }

        public ICollection<ControlEntrada> ControldeEntradas { get; set; }

    }
}
