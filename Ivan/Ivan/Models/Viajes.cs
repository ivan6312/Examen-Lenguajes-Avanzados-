using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ivan.Models
{
    public class Viajes
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Detalle { get; set; }
        public Choferes Chofer { get; set; }
        public Autos Auto { get; set; }
    }
}