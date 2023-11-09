using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FrmEmpleado : Form
    {
        public FrmEmpleado()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void FrmEmpleado_Load(object sender, EventArgs e)
        {
            listarRegistro();
        }

        private void listarRegistro()
        {
            try
            {
                dgvEmpleado.AutoGenerateColumns = false;
                dgvEmpleado.DataSource = NEmpleado.Listar();
                lblRegistro.Text = "Registros: " + dgvEmpleado.RowCount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + Environment.NewLine + "Mása detalles: " + ex.StackTrace);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtidEmpleado.TextLength > 0)
            {
                lblResultado.Text = NEmpleado.Actualizar(int.Parse(txtidEmpleado.Text), txtNombres.Text, txtApellidos.Text, txtEmail.Text, txtTelefono.Text, double.Parse(txtSalarioB.Text), double.Parse(txtISSS.Text), double.Parse(txtISR.Text), double.Parse(txtAFP.Text), double.Parse(txtOtrosDescuentos.Text));
                listarRegistro();
                limpiarTextos();
            }

            else
            {
                try
                {
                    //Insertar
                    lblResultado.Text = NEmpleado.Insertar(txtNombres.Text, txtApellidos.Text, txtEmail.Text, txtTelefono.Text, double.Parse(txtSalarioB.Text), double.Parse(txtISSS.Text), double.Parse(txtISR.Text), double.Parse(txtAFP.Text), double.Parse(txtOtrosDescuentos.Text));
                
               
            limpiarTextos();
            listarRegistro();
                }
                catch (Exception ex)
            {
                    MessageBox.Show(ex.Message + Environment.NewLine + "Mása detalles: " + ex.StackTrace);
                }

            }
            }

        private void limpiarTextos()
        {
            this.Controls.OfType<TextBox>().ToList().ForEach(t => t.ResetText());
            txtidEmpleado.ResetText();
            txtNombres.ResetText();
            txtApellidos.ResetText();
            txtEmail.ResetText();
            txtTelefono.ResetText();
            txtSalarioB.ResetText();
            txtISSS.ResetText();
            txtAFP.ResetText();
            txtISR.ResetText();
            txtOtrosDescuentos.ResetText();
        
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtidEmpleado.TextLength > 0)
                lblResultado.Text = NEmpleado.Eliminar(int.Parse(txtidEmpleado.Text));
            listarRegistro();
            limpiarTextos();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarTextos();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvEmpleado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvEmpleado.Rows.Count > 0)
            {
                txtidEmpleado.Text = dgvEmpleado.CurrentRow.Cells["idEmpleado"].Value.ToString();
            txtNombres.Text = dgvEmpleado.CurrentRow.Cells["nombres"].Value.ToString();
            txtApellidos.Text = dgvEmpleado.CurrentRow.Cells["apellidos"].Value.ToString();
            txtEmail.Text = dgvEmpleado.CurrentRow.Cells["mail"].Value.ToString();
            txtTelefono.Text = dgvEmpleado.CurrentRow.Cells["phone"].Value.ToString();
            txtSalarioB.Text = dgvEmpleado.CurrentRow.Cells["salarioBruto"].Value.ToString();
            txtISSS.Text = dgvEmpleado.CurrentRow.Cells["isss"].Value.ToString();
            txtISR.Text = dgvEmpleado.CurrentRow.Cells["isr"].Value.ToString();
            txtAFP.Text = dgvEmpleado.CurrentRow.Cells["afp"].Value.ToString();
            txtOtrosDescuentos.Text = dgvEmpleado.CurrentRow.Cells["otrosDescuentos"].Value.ToString();

            }
        }
    }
}
