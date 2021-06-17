using HouseDoor.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HouseDoor
{
    public partial class imoveis : Form
    {
        public imoveis()
        {
            InitializeComponent();
        }

  
        private void imoveis_Load(object sender, EventArgs e)
        {

        }

        private void txt_buscar_imovel_Click(object sender, EventArgs e)
        {
            string logradouro = txt_logradouro.Text.ToUpper();

            List<Imovel> imoveis = Banco.BuscaImovelPorLogradouro(logradouro);

         //   DataTable dataTable = CriarDataTable(imoveis);

            DataGridViewImageColumn dgvImageColumn = new DataGridViewImageColumn();
            dgvImageColumn.HeaderText = "Image";
            dgvImageColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;

            DataGridViewTextBoxColumn id_column = new DataGridViewTextBoxColumn();
            id_column.HeaderText = "Id";

            DataGridViewTextBoxColumn id_logradouro = new DataGridViewTextBoxColumn();
            id_logradouro.HeaderText = "logradouro";

            DataGridViewTextBoxColumn id_numero = new DataGridViewTextBoxColumn();
            id_numero.HeaderText = "numero";

            DataGridViewTextBoxColumn id_bairro = new DataGridViewTextBoxColumn();
            id_bairro.HeaderText = "bairro";

            DataGridViewTextBoxColumn id_cidade = new DataGridViewTextBoxColumn();
            id_cidade.HeaderText = "cidade";

            DataGridViewTextBoxColumn id_estado = new DataGridViewTextBoxColumn();
            id_estado.HeaderText = "estado";

            DataGridViewTextBoxColumn id_cep = new DataGridViewTextBoxColumn();
            id_cep.HeaderText = "cep";

            DataGridViewTextBoxColumn id_valor = new DataGridViewTextBoxColumn();
            id_valor.HeaderText = "valor";


            dgv_imovel.Columns.Add(dgvImageColumn);
            dgv_imovel.Columns.Add(id_column);
            dgv_imovel.Columns.Add(id_logradouro);
            dgv_imovel.Columns.Add(id_numero);
            dgv_imovel.Columns.Add(id_bairro);
            dgv_imovel.Columns.Add(id_cidade);
            dgv_imovel.Columns.Add(id_estado);
            dgv_imovel.Columns.Add(id_cep);


            //sssdgv_imovel.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_imovel.AllowUserToAddRows = false;
            dgv_imovel.RowTemplate.Height = 80;

            foreach (Imovel imovel in imoveis)
            {
               
                  //  Image imagem = Image.FromFile(imovel.imagem);


                dgv_imovel.Rows.Add(null, imovel.id , imovel.logradouro, imovel.numero, imovel.bairro, imovel.cidade, imovel.estado, imovel.cep/*,
                    imovel.tamanho_imovel, imovel.valor, imovel.descricao, imovel.condominio, imovel.iptu, imovel.quarto, imovel.banheiro,
                    imovel.vagas, imovel.andar, imovel.mobilia*/);
            }
        }

        private DataTable CriarDataTable(List<Imovel> imoveis)
        {
            DataTable dtb_imoveis = new DataTable();


            dtb_imoveis.Columns.Add("Id", typeof(int));
            dtb_imoveis.Columns.Add("Logradouro", typeof(string));
            dtb_imoveis.Columns.Add("Número", typeof(string));
            dtb_imoveis.Columns.Add("Bairro", typeof(string));
            dtb_imoveis.Columns.Add("Cidade", typeof(string));
            dtb_imoveis.Columns.Add("Estado", typeof(string));
            dtb_imoveis.Columns.Add("CEP", typeof(string));
            dtb_imoveis.Columns.Add("Tamanho imóvel", typeof(double));
            dtb_imoveis.Columns.Add("Valor", typeof(double));
            dtb_imoveis.Columns.Add("Descrição", typeof(string));
            dtb_imoveis.Columns.Add("Condominio", typeof(double));
            dtb_imoveis.Columns.Add("IPTU", typeof(double));
            dtb_imoveis.Columns.Add("Quartos", typeof(int));
            dtb_imoveis.Columns.Add("Banheiros", typeof(int));
            dtb_imoveis.Columns.Add("Vagas", typeof(int));
            dtb_imoveis.Columns.Add("Andar", typeof(int));
            dtb_imoveis.Columns.Add("Mobilia", typeof(bool));

            return dtb_imoveis;

        }

        private void txt_logradouro_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dgv_imovel_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv_imovel_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {


            string arg = dgv_imovel.Rows[e.RowIndex].Cells[1].Value.ToString();
            
            avaliacoes_listar listar = new avaliacoes_listar(arg);
            listar.ShowDialog();
        }
    }
}
