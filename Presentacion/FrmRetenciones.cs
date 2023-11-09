using MySqlX.XDevAPI.Relational;
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
    public partial class FrmRetenciones : Form
    {
        public FrmRetenciones()
        {
            InitializeComponent();
        }

        private void FrmRetenciones_Load(object sender, EventArgs e)
        {
            listarRegistro();
        }

        private void listarRegistro()
        {
            try
            {
                dgvRetenciones.AutoGenerateColumns = false;
                dgvRetenciones.DataSource = NRetenciones.Listar();
                label3.Text = "Registros: " + dgvRetenciones.RowCount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + Environment.NewLine + "Más detalles: " + ex.StackTrace);
            }
        }

       
        

        private void limpiarTextos()
        {
            this.Controls.OfType<TextBox>().ToList().ForEach(t => t.ResetText());
            txtid.ResetText();
            txtTramo.ResetText();
            txtHasta.ResetText();
            txtDesde.ResetText();
            txtPorcentaje.ResetText();
            txtSobreExceso.ResetText();
            txtCuotaFija.ResetText();

        }

        

       
        

        private void button3_Click(object sender, EventArgs e)
        {
            

            
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            if (txtid.TextLength > 0)
            {
                label4.Text = NRetenciones.Actualizar(int.Parse(txtid.Text), txtTramo.Text, double.Parse(txtDesde.Text), double.Parse(txtHasta.Text), double.Parse(txtPorcentaje.Text), double.Parse(txtSobreExceso.Text), double.Parse(txtCuotaFija.Text));
                limpiarTextos();
                listarRegistro();
            }

            else
            {
                try
                {
                    //Insertar
                    label4.Text = NRetenciones.Insertar(txtTramo.Text, double.Parse(txtDesde.Text), double.Parse(txtHasta.Text), double.Parse(txtPorcentaje.Text), double.Parse(txtSobreExceso.Text), double.Parse(txtCuotaFija.Text));
                    limpiarTextos();
                    listarRegistro();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + Environment.NewLine + "Más detalles: " + ex.StackTrace);
                }
            }
        }

        private void dgvRetenciones_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvRetenciones.Rows.Count > 0)
            {
                txtid.Text = dgvRetenciones.CurrentRow.Cells["id"].Value.ToString();
                txtTramo.Text = dgvRetenciones.CurrentRow.Cells["tramo"].Value.ToString();
                txtDesde.Text = dgvRetenciones.CurrentRow.Cells["desde"].Value.ToString();
                txtHasta.Text = dgvRetenciones.CurrentRow.Cells["hasta"].Value.ToString();
                txtPorcentaje.Text = dgvRetenciones.CurrentRow.Cells["porcentaje"].Value.ToString();
                txtSobreExceso.Text = dgvRetenciones.CurrentRow.Cells["sobreExceso"].Value.ToString();
                txtCuotaFija.Text = dgvRetenciones.CurrentRow.Cells["cuotaFija"].Value.ToString();

            }

        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            if (txtid.TextLength > 0)
                lblResultado.Text = NRetenciones.Eliminar(int.Parse(txtid.Text));
            listarRegistro();
            limpiarTextos();
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
