using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PizzeriaCrud
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
          
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void cadastrarpizza_Click(object sender, EventArgs e)
        {
            cadastrarp add = new cadastrarp();
            add.ShowDialog();
        }

        private void buscarpizza_Click(object sender, EventArgs e)
        {
            buscarp add = new buscarp();
            add.ShowDialog();
        }

        private void alterarpizza_Click(object sender, EventArgs e)
        {
            alterarp add = new alterarp();
            add.ShowDialog();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {
            Close();
        }
    }
}
