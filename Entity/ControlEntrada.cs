using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiExamenAngulaNet.Entity
{
    public class ControlEntrada
    {
        [Key]
        public int IdControl { get; set; }
        public string Tipo { get; set; }
        public int EntradaSalida { get; set; }
        public int IdHincha { get; set; }
        public string Asiento { get; set; }
        public int IdEntrada { get; set; }
        public int EstadioIdEstadio { get; set; }

        }

}
