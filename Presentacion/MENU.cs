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
    public partial class MENU : Form
    {
        public MENU()
        {
            InitializeComponent();
        }

        private void MENU_Load(object sender, EventArgs e)
        {

        }

        private void btnEmpleado_Click(object sender, EventArgs e)
        {
            FrmEmpleado Frm = new FrmEmpleado();
            Frm.Show();
        }

        private void btnISR_Click(object sender, EventArgs e)
        {
            FrmRetenciones Frm = new FrmRetenciones();
            Frm.Show();
        }

        private void btnRDLEY_Click(object sender, EventArgs e)
        {
            FrmRetencionesDley Frm = new FrmRetencionesDley();
            Frm.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
