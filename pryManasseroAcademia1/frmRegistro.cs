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
    public partial class frmRegistro : Form
    {
        public DateTime varInicioSesion;
        
        int varCodigo;
        string varNombre;
        string varPlan;
        bool varEstado;
        public frmRegistro()
        {
            InitializeComponent();
        }

        private void btnListado_Click(object sender, EventArgs e)
        {
            frmListado frmListado = new frmListado();   
            this.Hide();
            frmListado.ShowDialog();
            this.Show();

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        { 
            string estado;
            
            if (txtCodigo.Text == "" || txtNombre.Text == "" || cmbPlan.Text == "")
            {
                MessageBox.Show("Complete todos los campos", "Registro académico", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {           
                if (chkActivo.Checked)
                {
                    estado = "Activo";
                }
                else
                {
                    estado = "Inactivo";
                }

                MessageBox.Show(
                    "Registro completo\n\n" + 
                    "Codigo: " + txtCodigo.Text +
                    "\nNombre: " + txtNombre.Text + 
                    "\nPlan: " + cmbPlan.Text + 
                    "\nEstado: " + estado);
            }


        }
    }
}
