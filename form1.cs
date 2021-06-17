using HouseDoor.model;
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace HouseDoor
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
           

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
           

        private void btn_salvar_cliente_Click(object sender, EventArgs e)
        {
            Banco.CreateUsuario(new Usuario(
               txt_cpf.Text,
               txt_email.Text,
               txt_nome.Text,
               txt_sobrenome.Text,
               txt_senha.Text,
               txt_telefone.Text,
               txt_cep.Text,
               txt_endereco.Text,
               txt_bairro.Text,
               txt_cidade.Text,
               txt_uf.Text
               ));
        }
    }
}
