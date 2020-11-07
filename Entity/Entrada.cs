using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiExamenAngulaNet.Entity
{
    public class Entrada
    {

        [Key]
        public int IdEntrada { get; set; } //Clave primaria
        public string Nombre { get; set; }
    
    }
}
