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
    public class NRetenciones
    {
        public static DataTable Listar()
        {
            CRUD tabla = new CRUD();
            return tabla.Listar("retenciones");
        }

        public static DataTable BuscarLike(string textoBuscado, string dentroDelCampo)
        {
            CRUD tabla = new CRUD();
            return tabla.BuscarLike("retenciones", textoBuscado, dentroDelCampo);
        }

        public static DataTable BuscarById(string id)
        {
            CRUD tabla = new CRUD();
            return tabla.Buscar("retenciones", id, "id", "=");
        }

        public static string Insertar(string tramo, double desde, double hasta, double porcentaje, double sobreExceso, double cuotaFija )
        {

            if (!string.IsNullOrEmpty(tramo)  && desde > 0 && hasta > 0 && porcentaje > 0 && sobreExceso > 0 && cuotaFija > 0)
            {
                CRUD tabla = new CRUD();
                Retenciones r= new Retenciones();
                r.Tramo = tramo;
                r.Desde = desde;
                r.Hasta = hasta;
                r.Porcentaje = porcentaje;
                r.SobreExceso = sobreExceso;
                r.CuotaFija = cuotaFija;
                return tabla.Insertar(r, true);
            }
            else
            {
                return "No se pueden guardar registros vacios";
            }

        }

        public static string Actualizar(int id, string tramo, double desde, double hasta, double porcentaje, double sobreExceso, double cuotaFija)
        {
            if ((id != 0) && !string.IsNullOrEmpty(tramo) && desde > 0 && hasta > 0 && porcentaje > 0 && sobreExceso > 0 && cuotaFija > 0)
            {
                CRUD tabla = new CRUD();
                Retenciones retencion = new Retenciones();
                retencion.Id = id;
                retencion.Tramo = tramo;
                retencion.Desde = desde;
                retencion.Hasta = hasta;
                retencion.Porcentaje = porcentaje;
                retencion.SobreExceso = sobreExceso;
                retencion.CuotaFija = cuotaFija;
                
                return tabla.Actualizar(retencion);
            }
            else
                return "No se pueden guardar registros vacios";
        }

        public static string Eliminar(int id)
        {
            if (MessageBox.Show("Realmente desea eliminar el registro", System.Windows.Forms.Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                CRUD tabla = new CRUD();
                //OtrosDescuentos desc = new OtrosDescuentos();
                return tabla.Eliminar("retenciones", "id", id);
            }
            else
                return "Acción cancelada";
        }

    }
}
