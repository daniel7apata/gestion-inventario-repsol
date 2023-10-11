using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
   public class eLoteSalida
    {
        public int ID_LoteS { get; set; }
        public string tipo { get; set; }
        public int contenido_salida { get; set; }
        public int fecha_salida { get; set; }
     //   public int precio { get; set; }
        public string nombreciudad { get; set; }
        public int almacen { get; set; }
    }
}
