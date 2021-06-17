using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HouseDoor
{
    public partial class principal : Form
    {
        public principal()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void principal_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            login Entrar = new login();
            Entrar.ShowDialog();
            
        }

        private void btCadastrar1_Click(object sender, EventArgs e)
        {
            form1 Cadastrar = new form1();
            Cadastrar.ShowDialog();
        }

        private void btAvaliar1_Click(object sender, EventArgs e)
        {
            avaliacao Avaliar = new avaliacao();
            Avaliar.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            imovel Cadastrar_Imovel = new imovel();
            Cadastrar_Imovel.ShowDialog();
        }

        private void btBusca_Click(object sender, EventArgs e)
        {
            imoveis Buscar = new imoveis();
            Buscar.ShowDialog();
        }

        private void bt_listar_Click(object sender, EventArgs e)
        {
            avaliacoes_listar listar = new avaliacoes_listar();
            listar.ShowDialog();
        }

        private void principal_Load_1(object sender, EventArgs e)
        {

        }
    }
}
