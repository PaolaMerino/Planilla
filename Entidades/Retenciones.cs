using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Retenciones
    {
        public int Id { get; set; }
        public string Tramo { get; set; }
        public double Desde { get; set; }
        public double Hasta { get; set; }
        public double Porcentaje { get; set; }
        public double SobreExceso { get; set; }
        public double CuotaFija { get; set; }        
        



}
}