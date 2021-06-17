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
    public partial class avaliacoes_listar : Form
    {

        public avaliacoes_listar(string id)
        {

            InitializeComponent();
            avaliacoes(id);

        }
        public avaliacoes_listar()
        {
            InitializeComponent();


        }
        private void avaliacoes(string id)
        {

            int id_imovel = int.Parse(id);

            List<Avaliacao> avaliacoes = Banco.BuscaAvaliacaoPorImovel(id_imovel);

            DataTable table_avaliacoes = CriarDataTable(avaliacoes);

            dgv_avaliacoes.DataSource = table_avaliacoes;
        }

        private void listar_avaliacoes_Click(object sender, EventArgs e)
        {

            int id_imovel = int.Parse(txt_id_imovel.Text);

            List<Avaliacao> avaliacoes = Banco.BuscaAvaliacaoPorImovel(id_imovel);

            DataTable table_avaliacoes = CriarDataTable(avaliacoes);

            dgv_avaliacoes.DataSource = table_avaliacoes;
        }

        private DataTable CriarDataTable(List<Avaliacao> avaliacoes)
        {
            DataTable dtb_avaliacoes = new DataTable();

            dtb_avaliacoes.Columns.Add("id", typeof(int));
            dtb_avaliacoes.Columns.Add("Data Criacao", typeof(DateTime));
            dtb_avaliacoes.Columns.Add("Id imóvel", typeof(int));
            dtb_avaliacoes.Columns.Add("Id User", typeof(string));
            dtb_avaliacoes.Columns.Add("Tempo de contrato", typeof(int));
            dtb_avaliacoes.Columns.Add("Avaliação", typeof(int));
            dtb_avaliacoes.Columns.Add("Motivos", typeof(string));
            dtb_avaliacoes.Columns.Add("Recomenda Imóvel", typeof(bool));

            foreach (Avaliacao avaliacao in avaliacoes)
            {
                dtb_avaliacoes.Rows.Add(avaliacao.id, avaliacao.data_criacao,avaliacao.id_imovel,
                    avaliacao.id_user, avaliacao.tempo_contrato_meses, avaliacao.avaliacao,
                    avaliacao.motivos, avaliacao.recomenda_imovel);
            }

            return dtb_avaliacoes;

        }

        private void avaliacoes_listar_Load(object sender, EventArgs e)
        {

        }

        private void dgv_avaliacoes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            principal inicial = new principal();
            inicial.ShowDialog();
        }
    }
}
