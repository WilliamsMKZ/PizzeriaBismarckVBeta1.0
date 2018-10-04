using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzeriaCrud
{
    public partial class alterarp : Form
    {
        public alterarp()
        {
            InitializeComponent();
        }

        private void alterarp_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void mskPreçop_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtSABORP.Text = "";
            txtTAMANHOP.Text = "";
            mskPreçop.Text = "";
            MessageBox.Show("Concluido!");
        }
    }
}
