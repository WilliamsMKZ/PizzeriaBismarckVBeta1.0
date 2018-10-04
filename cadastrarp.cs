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
    public partial class cadastrarp : Form
    {
        public cadastrarp()
        {
            InitializeComponent();
        }

        private void tstId_Click(object sender, EventArgs e)
        {

        }

        private void cadastrarp_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Seu Pedido Foi Cancelado !!!");
            Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cadastro realizado com sucesso ✓");
            try
            {
                //string de conexao com banco de dados mysql 
                MySqlConnection objcon = new MySqlConnection("server=localhost; port=3306; UID=root; PWD=1234; database=pizza");
                //abre o banco de dados
                objcon.Open();
                MessageBox.Show("conectado");
            }
            
            catch
            {
                MessageBox.Show("não conectou");
            }
        }


        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
