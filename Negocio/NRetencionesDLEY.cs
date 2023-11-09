using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NRetencionesDLEY
    {

        public static DataTable MostrarTop()
        {
            CRUD tabla = new CRUD();
            return tabla.Consultar("Select * from retenciones1 limit 1");
        }

        
        public static string Insertar( double isss, double afp, double isssTecho)
        {

            if (isss > 0 && afp > 0 && isssTecho > 0)
            {
                CRUD tabla = new CRUD();
                Retenciones1 r = new Retenciones1();
                r.ISSS = isss;
                r.AFP = afp;
                r.ISSSTecho = isssTecho;                
                return tabla.Insertar(r, true);
            }
            else
            {
                return "No se pueden guardar registros vacios";
            }

        }

        public static string Actualizar(int id, double isss, double afp, double isssTecho)
        {
            if ((id != 0) && isss > 0 && afp > 0 && isssTecho > 0)
            {
                CRUD tabla = new CRUD();
                Retenciones1 r = new Retenciones1();
                r.Id = id;
                r.ISSS = isss;
                r.AFP = afp;
                r.ISSSTecho = isssTecho;

                return tabla.Actualizar(r);
            }
            else
                return "No se pueden guardar registros vacios";
        }
    }
}
