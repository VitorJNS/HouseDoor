using HouseDoor.model;
using System;
using System.IO;
using System.Windows.Forms;

namespace HouseDoor
{
    public partial class imovel : Form
    {
        public imovel()
        {
            InitializeComponent();
        }

        private void imovel_Load(object sender, EventArgs e)
        {

        }

        private void txt_save_imovel_Click(object sender, EventArgs e)
        {
            Banco.CreateImovel(new Imovel(
                0,
                txt_logradouro.Text,
                txt_numero.Text,
                txt_bairro.Text,
                txt_cidade.Text,
                txt_estado.Text,
                txt_cep.Text,
                float.Parse(txt_tamanho_imovel.Text),
                float.Parse(txt_valor.Text),
                txt_descricao.Text,
                float.Parse(txt_condominio.Text),
                float.Parse(txt_iptu.Text),
                int.Parse(txt_nmr_quarto.Text),
                int.Parse(txt_numero_banheiro.Text),
                int.Parse(txt_vagas.Text),
                int.Parse(txt_andar.Text),
                bool.Parse(txt_mobilia.Text),
                txt_imagem_imovel.Text
                ));
        }

        private void txt_imagem_imovel_Click(object sender, EventArgs e)
        {
            OpenFileDialog v1 = new OpenFileDialog();
            v1.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            
            if(v1.ShowDialog() == DialogResult.OK)
            {
                txt_imagem_imovel.Text = v1.FileName;
            }
        
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            principal inicial = new principal();
            inicial.ShowDialog();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            avaliacoes_listar listar = new avaliacoes_listar();
            listar.ShowDialog();
            
        }
    }
}
