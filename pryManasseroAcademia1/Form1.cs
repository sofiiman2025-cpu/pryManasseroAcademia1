using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryManasseroAcademia1
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            frmRegistro frmRegistro = new frmRegistro();

            frmRegistro.varInicioSesion = DateTime.Now;

            this.Hide();
            frmRegistro.ShowDialog();
            this.Show();
        }

        private void frmInicio_Load(object sender, EventArgs e)
        {
            //almacenar la fecha y hora de inicio de sesión
            //variables
            //varInicioSesion = DateTime.Now; //inicio de variables
        }
    }
}
