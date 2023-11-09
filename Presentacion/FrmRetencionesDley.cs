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
    public partial class FrmRetencionesDley : Form
    {
        public FrmRetencionesDley()
        {
            InitializeComponent();
        }

        
        private void top1()
        {
            DataTable DT = NRetencionesDLEY.MostrarTop();
            txtid.Text = DT.Rows[0]["id"].ToString();
            txtAFP.Text = DT.Rows[0]["afp"].ToString();
            txtISSS.Text = DT.Rows[0]["isss"].ToString();
            txtISSSTecho.Text = DT.Rows[0]["isssTecho"].ToString();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtid.TextLength > 0)
            {
                label4.Text = NRetencionesDLEY.Actualizar(int.Parse(txtid.Text), double.Parse(txtAFP.Text), double.Parse(txtISSS.Text), double.Parse(txtISSSTecho.Text));
                
                
            }

            else
            {
                try
                {
                    //Insertar
                    label4.Text = NRetencionesDLEY.Insertar(double.Parse(txtAFP.Text), double.Parse(txtISSS.Text), double.Parse(txtISSSTecho.Text));
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + Environment.NewLine + "Más detalles: " + ex.StackTrace);
                }
            }
        }

        private void FrmRetencines1_Load(object sender, EventArgs e)
        {
            top1();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
