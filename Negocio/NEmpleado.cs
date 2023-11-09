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
    public class NEmpleado
    {

        public static DataTable Listar()
        {
            CRUD tabla = new CRUD();
            return tabla.Listar("Empleado");
        }

        public static DataTable BuscarLike(string textoBuscado, string dentroDelCampo)
        {
            CRUD tabla = new CRUD();
            return tabla.BuscarLike("Empleado", textoBuscado, dentroDelCampo);
        }

        public static DataTable BuscarById(string id)
        {
            CRUD tabla = new CRUD();
            return tabla.Buscar("Empleado", id, "idEmpleado", "=");
        }

        public static string Insertar(string name, string lastName, string mail, string phone, double salarioB, double isss=0, double isr=0 ,double afp=0, double otros=0)
        {

            if (!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(lastName) && !string.IsNullOrEmpty(mail) && !string.IsNullOrEmpty(lastName) && salarioB > 0)
            {
                CRUD tabla = new CRUD();
               Empleado empleado = new Empleado();
                empleado.Nombres = name;
                empleado.Apellidos = lastName;
                empleado.Mail= mail;
                empleado.Phone=phone;
                empleado.salarioBruto  = salarioB;
                empleado.ISSS= isss;
                empleado.ISR = isr;
                empleado.AFP = afp;
                empleado.otrosDescuentos = otros;
                return tabla.Insertar(empleado , true);
            }
            else { 
                return "No se pueden guardar registros vacios"; 
            }
                
        }

        public static string Actualizar(int id,string name, string lastName, string mail, string phone, double salarioB, double isss = 0, double isr = 0, double afp = 0, double otros = 0)
        {
            if ((id != 0) &&  !string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(lastName) && !string.IsNullOrEmpty(mail) && !string.IsNullOrEmpty(lastName) && salarioB > 0)
            {
                CRUD tabla = new CRUD();
                Empleado empleado = new Empleado();
                empleado.idEmpleado = id;
                empleado.Nombres = name;
                empleado.Apellidos = lastName;
                empleado.Mail = mail;
                empleado.Phone = phone;
                empleado.salarioBruto = salarioB;
                empleado.ISSS = isss;
                empleado.ISR = isr;
                empleado.AFP = afp;
                empleado.otrosDescuentos = otros;
                return tabla.Actualizar(empleado);
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
                return tabla.Eliminar("Empleado", "idEmpleado", id);
            }
            else
                return "Acción cancelada";
            }

      

    }
}
