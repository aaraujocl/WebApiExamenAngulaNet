using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiExamenAngulaNet.Entity
{
    public class Profesores
    {
        public Profesores()
        {
            Cursos = new HashSet<Hincha>();
        }
        [Key]
        public int IdProfesor { get; set; }
        public string Nombre { get; set; }
        public string especialidad { get; set; }

       
        public ICollection<Hincha> Cursos { get; set; }
    }
}
