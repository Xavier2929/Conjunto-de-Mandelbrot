using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conjunto_de_Mandelbrot
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
        }


      

        private void button1_Click(object sender, EventArgs e)
        {
            clsFuncion obj = new clsFuncion();

           obj.conjuntoMandelbrot(pcBx);
        }
    }
}
