using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using TomMotos.Conexao;

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
            txtsubitotal.Text = 0.ToString();
            // btnAc.Visible = false;

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (listView_venda.Items.Count > 0)
                listView_venda.Items.Remove(listView_venda.SelectedItems[0]);
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            int preco_servico = 0, pt;
            preco_servico = int.Parse(txt_pmo.Text);
            pt = int.Parse(txtsubitotal.Text);
            if (txt_pmo.Text != "" || txtDescServ.Text != "")
            {

                if (servicos == 0) servicos = 1;
                else servicos += 1;

                SERVICO[1] = txtDescServ.Text.ToString();
                SERVICO[2] = txt_pmo.Text.ToString();

                SERVICO[0] = servicos.ToString();
                listView1.Items.Add(new ListViewItem(SERVICO));
                pt += preco_servico;
                txtsubitotal.Text = pt.ToString();
            }
            else MessageBox.Show("VERIFIQUE SE EXISTE CAMPOS EM BRANCOS");


        }

        private void txt_Ds_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            btnAc.Visible = true;            

        }

        private void listView_venda_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int valor_produto, total;
            if (txtsubitotal.Text == "") total = 0;
            else total = int.Parse(txtsubitotal.Text);
            string select = "select id_produto, descricao_produto, marca_produto quantidade_produto, valor_produto, imagem_produto  from tb_produto where id_produto = "+ txtIdProduto.Text.ToString();
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
                txtsubitotal.Text = total.ToString();
                valor_total = valor_produto * int.Parse(txtqtd.Text);
                if (itens == 0)
                    itens = 1;
                else itens += 1;
                //if (string.IsNullOrEmpty(id_produto) || string.IsNullOrEmpty(nome_produto) || string.IsNullOrEmpty(valor_produto.ToString()) || string.IsNullOrEmpty(txtqtd.Text)) 
                // return;                
                item[0] = itens.ToString();
                item[1] = id_produto;
                item[2] = nome_produto;
                item[3] = txtqtd.Text;
                item[4] = valor_produto.ToString();
                item[5] = valor_total.ToString();
               
                listView_venda.Items.Add(new ListViewItem(item));
                //txtIdProduto.Clear();
                //txtdesc.Clear();
               // txtIdProduto.Focus();
                
                //listView_venda.//( "1", id_produto, nome_produto, txtqtd.Text, valor_produto, valor_total));
                //ltb_nota.Items.Add("    " + txtqtd.Text.ToString() + " x UN                                        R$ " + valor_produto + "                                                       R$  " + valor_produto * int.Parse(txtqtd.Text));
                //ltb_nota.DataSource = null;
                //ltb_nota.DataSource = nota;
                
            }
            else MessageBox.Show("PRODUTO NÃO ENCONTRADO!!");
        }
    }
}
