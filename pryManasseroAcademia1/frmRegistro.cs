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

        int indiceFIla = 0;
        string[,] matMaterias = new string[2, 5];


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
                cmbPlan.Focus();
            }
            else
            {
                // varCodigo = Convert.ToInt32(txtCodigo.Text);
                // varNombre = txtNombre.Text;
                // varPlan = cmbPlan.Text;

                matMaterias[indiceFIla,0] = txtCodigo.Text;
                matMaterias[indiceFIla,1] = txtNombre.Text;
                matMaterias[indiceFIla,2] = cmbPlan.Text;
               


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
            indiceFIla++;

        }

        private void btnCargadePlan_Click(object sender, EventArgs e)
        {
            frmCargaPlan frmCargaPlan = new frmCargaPlan();
            this.Hide();
            frmCargaPlan.ShowDialog();
            this.Show();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
