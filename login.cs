using HouseDoor.model;
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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool login;
            login = Banco.Login(txtCPF.Text, txtSenha.Text);
            if (login)
            {
                this.Hide();
                imoveis Buscar = new imoveis();
                Buscar.ShowDialog();
                
            }
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtCPF.Text = "";
            txtSenha.Text = "";
        }

        private void label4_Click(object sender, EventArgs e)
        {
            form1 Cadastrar = new form1();
            Cadastrar.ShowDialog();
        }
    }
}
