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
    public partial class avaliacao : Form
    {
        public avaliacao()
        {
            InitializeComponent();
        }

        private void avaliacao_Load(object sender, EventArgs e)
        {
            cb_recomenda.Items.Add("True");
            cb_recomenda.Items.Add("False");
            cb_recomenda.SelectedIndex = 0;

            combobox1.Items.Add(1);
            combobox1.Items.Add(2);
            combobox1.Items.Add(3);
            combobox1.Items.Add(4);
            combobox1.Items.Add(5);
            combobox1.SelectedIndex = 0;

        }

        private void btn_cadastrar_avaliacao_Click(object sender, EventArgs e)
        {
            Banco.CreateAvaliacao(new Avaliacao(
                int.Parse(txt_id_imovel.Text),
                txt_id_user.Text,
                int.Parse(txt_tempo_contrato.Text),
                int.Parse(combobox1.Text),
                txt_motivo.Text,
                bool.Parse(cb_recomenda.Text)
                ));
        }

        private void cb_recomenda_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
