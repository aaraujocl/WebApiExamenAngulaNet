using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiExamenAngulaNet.Entity
{
    public class Hincha
    {
        public Hincha()
        {
          
        }

        [Key]
        public int IdHincha { get; set; } //Clave primaria
        public string Nombre { get; set; }
       
    }
}
