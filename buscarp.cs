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
    public partial class buscarp : Form
    {
        public buscarp()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Busca Concluida !");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Busca Cancelada !!!");
            Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("");
        }
    }
}
