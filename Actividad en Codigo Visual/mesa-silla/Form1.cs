using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mesa_silla
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Presupuesto a = new Presupuesto("juan","corrientes 93");
            Mesa m1 = new Mesa(10, 30.1, 15.4, 6);
             a.AgregarProducto(m1);
            m1.Codigo = 1234;
            comboBox1.Items.Add();
            
            
        }
    }
}
