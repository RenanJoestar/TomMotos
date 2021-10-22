using MySql.Data    .MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using TomMotos.Conexao;
using TomMotos.Classes;
using TomMotos.Model;

namespace TomMotos.view
{
    public partial class Fmrcaixa : Form
    {
        string[] SERVICO = new string[4];
        string[] item = new string[6];
        List<string> nota = new List<string>();
        string id_produto, nome_produto;
        int valor_total, itens = 0, servicos = 0;
        MySqlConnection conexao = ConnectionFactory.getConnection();
        public Fmrcaixa()
        {
            InitializeComponent();
            
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void Fmrcaixa_FormClosed(object sender, FormClosedEventArgs e)
        {
            Fmrsumario fmrsumario = new Fmrsumario();
            fmrsumario.Show();
        }
        private void Fmrcaixa_Load(object sender, EventArgs e)
        {
            listView_venda.Items.Clear();
            lblSubitotal.Text = 0.ToString();
        }

        private void btnFinalizaVenda_Click(object sender, EventArgs e)
        {
                string descricao = "", idVenda = "";
                double valorMaoDeObra = 0;
                CaixaDAO vendaDAO = new CaixaDAO();
                ProdutoUsadoDAO produtoDAO = new ProdutoUsadoDAO();
                CaixaModel objVenda = new CaixaModel();
                ProdutoUsadoModel objProduto = new ProdutoUsadoModel();
           
                try
                {
                    for (int i = 0; i < listView_mao_de_obra.Items.Count; i++)
                    {
                        descricao = descricao + " | " + listView_mao_de_obra.Items[i].SubItems[1].Text;
                        valorMaoDeObra = valorMaoDeObra + int.Parse(listView_mao_de_obra.Items[i].SubItems[2].Text);
                    }
                }
                catch (Exception) { }

                objVenda.descricao = descricao;
                objVenda.validade_orcamento_servico = DateTime.Now;
                objVenda.preco_mao_de_obra = valorMaoDeObra;
                objVenda.fk_cliente_id = 9; // cliente null
                objVenda.fk_veiculo_id = 8; // veiculo null
                vendaDAO.cadastrar(objVenda);
                
                idVenda = vendaDAO.listarUltimaVenda();
                try
                    {
                    for (int i = 0; i < listView_venda.Items.Count; i++)
                    {
                        objProduto.quantidade_produto_usado = double.Parse(listView_venda.Items[i].SubItems[3].Text);
                        objProduto.fk_produto_id = int.Parse(listView_venda.Items[i].SubItems[1].Text);
                        objProduto.fk_venda_id = int.Parse(idVenda);
                        objProduto.validade_da_garantia_produto = DateTime.Now;

                        produtoDAO.cadastrar(objProduto);
                    }
                }
                catch (Exception) { }

                objVenda.id_venda = idVenda;
                vendaDAO.mudarStatusVenda(objVenda, true);
        }

        private void btnAcProduto_Click(object sender, EventArgs e)
        {
            int valor_produto, total;
            if (lblSubitotal.Text == "") total = 0;
            else total = int.Parse(lblSubitotal.Text);
            string select = "select id_produto, descricao_produto, marca_produto quantidade_produto, valor_produto, imagem_produto  from tb_produto where id_produto = " + txtIdProduto.Text.ToString();
            MySqlCommand executacmdsql = new MySqlCommand(select, conexao);

            MySqlDataAdapter da = new MySqlDataAdapter(executacmdsql);

            DataSet ds = new DataSet();
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (Convert.IsDBNull(ds.Tables[0].Rows[0]["imagem_produto"]))
                {
                    ptb_imagem.Image = null;
                }
                else
                {
                    MemoryStream ms = new MemoryStream((byte[])ds.Tables[0].Rows[0]["imagem_produto"]);
                    ptb_imagem.Image = new Bitmap(ms);
                }
                id_produto = ds.Tables[0].Rows[0]["id_produto"].ToString();
                nome_produto = ds.Tables[0].Rows[0]["descricao_produto"].ToString();
                valor_produto = int.Parse(ds.Tables[0].Rows[0]["valor_produto"].ToString());

                total = total + (valor_produto * int.Parse(txtqtd.Text));
                lblSubitotal.Text = total.ToString();
                valor_total = valor_produto * int.Parse(txtqtd.Text);
                if (itens == 0) itens = 1;
                else itens += 1;

                item[0] = itens.ToString();
                item[1] = id_produto;
                item[2] = nome_produto;
                item[3] = txtqtd.Text;
                item[4] = valor_produto.ToString();
                item[5] = valor_total.ToString();

                listView_venda.Items.Add(new ListViewItem(item));
            }
            else MessageBox.Show("PRODUTO NÃO ENCONTRADO!!");
        }

        private void btnAcServico_Click(object sender, EventArgs e)
        {
            int preco_servico = 0, pt;
            preco_servico = int.Parse(txt_pmo.Text);
            pt = int.Parse(lblSubitotal.Text);
            if (txt_pmo.Text != "" || txtDescServ.Text != "")
            {
                if (servicos == 0) servicos = 1;
                else servicos += 1;

                SERVICO[1] = txtDescServ.Text.ToString();
                SERVICO[2] = txt_pmo.Text.ToString();

                SERVICO[0] = servicos.ToString();
                listView_mao_de_obra.Items.Add(new ListViewItem(SERVICO));
                pt += preco_servico;
                lblSubitotal.Text = pt.ToString();
            }
            else MessageBox.Show("VERIFIQUE SE EXISTE CAMPOS EM BRANCOS");
        }

        private void BtnExcluir_item_Click(object sender, EventArgs e)
        {
            if (listView_venda.SelectedItems.Count > 0)
            {
                try
                {
                    ListViewItem produto = listView_venda.SelectedItems[0];
                    int subitotal = int.Parse(lblSubitotal.Text) - int.Parse(produto.SubItems[5].Text);
                    listView_venda.Items.Remove(listView_venda.SelectedItems[0]);
                    lblSubitotal.Text = subitotal.ToString();
                }
                catch (Exception erro) { }
            }
            else
            {
                try
                {
                    ListViewItem maoDeObra = listView_mao_de_obra.SelectedItems[0];
                    int subitotal = int.Parse(lblSubitotal.Text) - int.Parse(maoDeObra.SubItems[2].Text);
                    listView_mao_de_obra.Items.Remove(listView_mao_de_obra.SelectedItems[0]);
                    lblSubitotal.Text = subitotal.ToString();
                }
                catch (Exception erro) { }
            }
        }
    }
}
