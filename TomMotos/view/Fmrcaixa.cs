using MySql.Data.MySqlClient;
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
using TomMotos.Conexao;

namespace TomMotos.view
{
    public partial class Fmrcaixa : Form
    {
        string id_produto, nome_produto,valor_total;
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
            btnAc.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            btnAc.Visible = true;
            ltb_nota.Items.Add("--------------------------------------------------------------------------------------------------------------------------------------");
            ltb_nota.Items.Add("ITEM Codigo                           Descricao                                                                                       ");
            ltb_nota.Items.Add("QTD      UN                          VL.UNIT.(R$)                                   VL.ITEM(R$)");
            ltb_nota.Items.Add("--------------------------------------------------------------------------------------------------------------------------------------");
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
                ltb_nota.Items.Add("" + id_produto + "                                               " + nome_produto + "                                                                                       ");
                ltb_nota.Items.Add("    " + txtqtd.Text.ToString() + " x UN                                        R$ " + valor_produto + "                                                       R$  " + valor_produto * int.Parse(txtqtd.Text));

            }
            else MessageBox.Show("PRODUTO NÃO ENCONTRADO!!");



        }
    }
}
