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
    public partial class frmCargaPlan : Form
    {
        //declaracion--> string[] arraryPlan --- array de una
        //dimension - vector
        string[] arrayPlan = new string[4];
        //crea en memoria y declara los espacios --> = new string[4]

        int varIndice = 0;

        public frmCargaPlan()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (txtPlan.Text != "")
            {
               arrayPlan[varIndice] = txtPlan.Text;
                varIndice++;    

                txtPlan.Clear();

                if (varIndice > arrayPlan.Length)
                {             
                    btnRegistrar.Enabled = false;
                    txtPlan.Enabled = false;
                }
            }
            
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            //int indiceRecorrido = 0;

            //while (indiceRecorrido < arrayPlan.Length)
            //{
            //    lstPlanes.Items.Add(arrayPlan[indiceRecorrido]);
            //    indiceRecorrido++;

            //}

            for (int i = 0; i < arrayPlan.Length; i++)
            {
                lstPlanes.Items.Add(arrayPlan[i]);
            }
        }
    }
}
