using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
   public class eLoteSalida
    {
        public int ID { get; set; }
        public string Combustible { get; set; }
        public int Cantidad { get; set; }
        public int Fecha { get; set; }
     //   public int precio { get; set; }
        public string Ciudad { get; set; }
        public int Almacen { get; set; }
    }
}
