using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Empleado : Persona
    {
        public int idEmpleado { get; set; }//como manejará el autoincrement
        public double salarioBruto { get; set; }
        public double ISSS{ get; set; }
        public double ISR{ get; set; }
        public double AFP{ get; set; }
        public double otrosDescuentos { get; set; }

        public double GetOtrosDescuentos()
        {
            this.otrosDescuentos = 0;

            return this.otrosDescuentos;
        }

    }
}
