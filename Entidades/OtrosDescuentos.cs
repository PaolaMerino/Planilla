using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class OtrosDescuentos
    {
        public int id { get; set; }
        public int idEmpleado { get; set; }
        public string tipoDescuento { get; set; }
        public double valorDescuento { get; set; }
    }
}
