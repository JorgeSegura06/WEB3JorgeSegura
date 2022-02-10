using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmPrincipal3 : Form
    {
        public frmPrincipal3()
        {
            InitializeComponent();
        }

        private void pbCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
            //this.Close();
        }

        private void frmPrincipal3_Load(object sender, EventArgs e)
        {
            lblTitulo.Text = "UTN App";
        }
    }
}
