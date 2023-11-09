using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Negocio
{
    public class NOtrosDescuentos
    {
        public static DataTable Listar()
        {
            CRUD tabla = new CRUD();
            return tabla.Listar("OtrosDescuentos");
        }
        public static DataTable BuscarLike(string textoBuscado, string dentroDelCampo)
        {
            CRUD tabla = new CRUD();
            return tabla.BuscarLike("OtrosDescuentos", textoBuscado, dentroDelCampo);
        }

        public static DataTable BuscarById(string id)
        {
            CRUD tabla = new CRUD();
            return tabla.Buscar("OtrosDescuentos", id, "idEmpleado", "=");
        }
        public static string Insertar(int id, string tipoDesc, double descuento)
        {
            if ((id != 0) && !string.IsNullOrEmpty(tipoDesc) && descuento > 0)
            {
                CRUD tabla = new CRUD();
                OtrosDescuentos desc = new OtrosDescuentos();
                desc.idEmpleado = id;
                desc.tipoDescuento = tipoDesc;
                desc.valorDescuento = descuento;
                return tabla.Insertar(desc, false);
            }
            else
                return "No se pueden guardar registros vacios";
        }

        public static string Actualizar(int id, string tipoDesc, double descuento)
        {
            if ((id != 0) && !string.IsNullOrEmpty(tipoDesc) && descuento > 0)
            {
                CRUD tabla = new CRUD();
                OtrosDescuentos desc = new OtrosDescuentos();
                desc.idEmpleado = id;
                desc.tipoDescuento = tipoDesc;
                desc.valorDescuento = descuento;

                //tabla.Actualizar(desc);
                return tabla.Actualizar(desc);


            }
            else
                return "No se pueden guardar registros vacios";
        }
        public static string Eliminar(int id)
        {
            if (MessageBox.Show("Realmente desea eliminar el registro", System.Windows.Forms.Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                CRUD tabla = new CRUD();
                OtrosDescuentos desc = new OtrosDescuentos();
                return tabla.Eliminar("OtrosDescuentos", "id", id);
            }
            else
                return "Acción cancelada";


        }
        public static DataTable GetCampos()
        {
            CRUD tabla = new CRUD();
            return tabla.GetColumns("OtrosDescuentos");
        }
    }
}

