using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ivan.Models
{
    public class Gastos
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public double Monto { get; set; }
        public string Descripcion { get; set; }
    }
}