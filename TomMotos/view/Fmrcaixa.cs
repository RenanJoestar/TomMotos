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
using System.Net.Mail;
using System.Net;

namespace TomMotos.view
{
    public partial class Fmrcaixa : Form
    {
        double desconto;
        string[] SERVICO = new string[4];
        string[] item = new string[6];
        List<string> nota = new List<string>();
        string id_produto, nome_produto;
        int itens = 0, servicos = 0;
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
            lblSubitotal.Text = 0.ToString();
            dgProdutos.Columns[2].Width=200;
            dgServicos.Columns[1].Width = 243;
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
                    for (int i = 0; i < dgServicos.Rows.Count -1; i++)
                    {
                        descricao = descricao + " | " + dgServicos.Rows[i].Cells[1].Value.ToString();
                    valorMaoDeObra = valorMaoDeObra + int.Parse(dgServicos.Rows[i].Cells[2].Value.ToString());
                    }
                }
                catch (Exception) { }

                objVenda.descricao = descricao.ToUpper();
                objVenda.validade_orcamento_servico = DateTime.Now;
                objVenda.preco_mao_de_obra = valorMaoDeObra;
                objVenda.desconto = double.Parse(txtdesc.Text);
                objVenda.total = double.Parse(lblSubitotal.Text);
                objVenda.fk_cliente_id = 9; // cliente null
                objVenda.fk_veiculo_id = 8; // veiculo null
                vendaDAO.cadastrar(objVenda);
                
                idVenda = vendaDAO.listarUltimaVenda();
                try
                    {
                    for (int i = 0; i < dgProdutos.Rows.Count -1; i++)
                    {
                   
                        objProduto.quantidade_produto_usado = double.Parse(dgProdutos.Rows[i].Cells[3].Value.ToString());
                        objProduto.fk_produto_id = int.Parse(dgProdutos.Rows[i].Cells[1].Value.ToString());
                        objProduto.fk_venda_id = int.Parse(idVenda);
                        objProduto.validade_da_garantia_produto = DateTime.Now;

                        produtoDAO.cadastrar(objProduto);
                   
                }
                }
                catch (Exception) { }

                objVenda.id_venda = idVenda;
                vendaDAO.mudarStatusVenda(objVenda, true);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string htmlString = getHtml(dgProdutos,dgServicos);            
            Email(htmlString);
        }
        public string getHtml(DataGridView grid, DataGridView grid2)
        {
            try
            {                
                string messageBody = "<font> SEU COMPROVANTE DE COMPRA NA TOMMOTOS: </font><br><br>", messageB = "", total="";
                if (grid.RowCount == 0 || grid2.RowCount == 0) return messageBody;
               
                string htmlTableStart = "<table style=\"border-collapse:collapse; text-align:center;\">";
                string htmlTableEnd = "</table><br>";
                

                string htmlHeaderRowStart = "<tr style=\"background-color:#6FA1D2; color:#ffffff;\">";
                string htmlHeaderRowEnd = "</tr>";

                string htmlTrStart = "<tr style=\"color:#555555;\">";
                string htmlTrEnd = "</tr>";

                string htmlTdStart = "<td style=\" border-color:#5c87b2; border-style:solid; border-width:thin; padding: 5px;\">";
                string htmlTdEnd = "</td>";
                if (dgProdutos.Rows.Count > 1)
                {
                    messageBody += htmlTableStart;
                    messageBody += htmlHeaderRowStart;
                    messageBody += htmlTdStart + "ITEM" + htmlTdEnd;
                    messageBody += htmlTdStart + "CODIGO" + htmlTdEnd;
                    messageBody += htmlTdStart + "DESCRIÇÃO PRODUTO" + htmlTdEnd;
                    messageBody += htmlTdStart + "QUANTIDADE" + htmlTdEnd;
                    messageBody += htmlTdStart + "VL.UNIT.(R$)" + htmlTdEnd;
                    messageBody += htmlTdStart + "VL.ITEM.(R$)" + htmlTdEnd;
                    messageBody += htmlHeaderRowEnd;
                }

                if (dgServicos.Rows.Count > 1 )
                {
                    messageB += htmlTableStart;
                    messageB += htmlHeaderRowStart;
                    messageB += htmlTdStart + "    " + htmlTdEnd;
                    messageB += htmlTdStart + "DESCRIÇÃO SERVIÇO" + htmlTdEnd;
                    messageB += htmlTdStart + "VALOR(R$)" + htmlTdEnd;
                    messageB += htmlHeaderRowEnd;
                }
              

                total += htmlTableStart;
                total += htmlHeaderRowStart;
                total += htmlTdStart + "DATA" + htmlTdEnd;
                total += htmlTdStart + "TOTAL(R$)" + htmlTdEnd;
                total += htmlHeaderRowEnd;

                total = total + htmlTrStart;
                total = total + htmlTdStart + DateTime.Now.ToString() + htmlTdEnd;
                total = total + htmlTdStart + lblSubitotal.Text.ToString() + htmlTdEnd;
                total = total + htmlTrEnd;

                for (int i = 0; i <= grid.RowCount -2; i++)
                {
                    messageBody = messageBody + htmlTrStart;
                    messageBody = messageBody + htmlTdStart + grid.Rows[i].Cells[0].Value + htmlTdEnd;
                    messageBody = messageBody + htmlTdStart + grid.Rows[i].Cells[1].Value + htmlTdEnd;
                    messageBody = messageBody + htmlTdStart + grid.Rows[i].Cells[2].Value + htmlTdEnd;
                    messageBody = messageBody + htmlTdStart + grid.Rows[i].Cells[3].Value + htmlTdEnd;
                    messageBody = messageBody + htmlTdStart + grid.Rows[i].Cells[4].Value + htmlTdEnd;
                    messageBody = messageBody + htmlTdStart + grid.Rows[i].Cells[5].Value + htmlTdEnd;
                    messageBody = messageBody + htmlTrEnd;
                 
                }
                for (int a = 0; a <= grid2.RowCount -2; a++)
                {
                    messageB = messageB + htmlTrStart;
                    messageB = messageB + htmlTdStart + grid2.Rows[a].Cells[0].Value + htmlTdEnd;
                    messageB = messageB + htmlTdStart + grid2.Rows[a].Cells[1].Value + htmlTdEnd;
                    messageB = messageB + htmlTdStart + grid2.Rows[a].Cells[2].Value + htmlTdEnd;
                    messageB = messageB + htmlTrEnd;

                }

                string final = messageBody + htmlTableEnd + messageB + htmlTableEnd + total + htmlTableEnd;

                return final;
            }

            catch (Exception erro) {
                MessageBox.Show(" "+ erro);
                return null;
            }
        }
  
        public static void Email(string htmlString)
        {
            
            try
            {
                string emailRementente = "tommotos2020@gmail.com", senhaRementente = "972494264", emailDestinatario = "";
                MailMessage message = new MailMessage();                
                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                message.From = new MailAddress(emailRementente); // EMAIL REMETENTE
                message.To.Add(new MailAddress(emailDestinatario)); // EMAIL DESTINATARIO
                message.Subject = "Test";
                message.IsBodyHtml = true;
                message.Body = htmlString;                
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential(emailRementente, senhaRementente);
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Send(message);              
                MessageBox.Show("Email enviado com sucesso", "Nota enviada", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
            }
            catch (Exception erro)
            {
                MessageBox.Show("Test "+ erro);
                MessageBox.Show("Erro de conexão, Email não enviado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgServicos_MouseDown(object sender, MouseEventArgs e)
        {
            dgProdutos.ClearSelection();
        }

        private void dgProdutos_MouseDown(object sender, MouseEventArgs e)
        {
            dgServicos.ClearSelection();
        }

        private void Fmrcaixa_MouseClick(object sender, MouseEventArgs e)
        {
            dgProdutos.ClearSelection();
            dgServicos.ClearSelection();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
            if (txtdesc.Text != "")
            {
                desconto = double.Parse(lblSubitotal.Text) * (double.Parse(txtdesc.Text) / 100);
                lblSubitotal.Text = (double.Parse(lblSubitotal.Text) - desconto).ToString();
            }
        }

        private void btnAcProduto_Click(object sender, EventArgs e)
        {
            double valor_produto, valor_total, total;
            if (lblSubitotal.Text == "") total = 0;
            else total = double.Parse(lblSubitotal.Text);
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
                valor_total = valor_produto * double.Parse(txtqtd.Text);
              
                if (itens == 0) itens = 1;
                else itens += 1;

                item[0] = itens.ToString();
                item[1] = id_produto;
                item[2] = nome_produto;
                item[3] = txtqtd.Text;
                item[4] = valor_produto.ToString();
                item[5] = valor_total.ToString();

                dgProdutos.Rows.Add((item));
            }
            else MessageBox.Show("PRODUTO NÃO ENCONTRADO!!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lblSubitotal.Text = (double.Parse(lblSubitotal.Text) + desconto).ToString();
            desconto = 0;
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
                dgServicos.Rows.Add((SERVICO));
                pt += preco_servico;
                lblSubitotal.Text = pt.ToString();
            }
            else MessageBox.Show("VERIFIQUE SE EXISTE CAMPOS EM BRANCOS");
        }

        private void BtnExcluir_item_Click(object sender, EventArgs e)
        {
            int subitotal = int.Parse(lblSubitotal.Text);
            if (dgProdutos.SelectedCells.Count > 0)
             {
                 try
                 {
                    int rowProduto = dgProdutos.CurrentCell.RowIndex;
                    int rowPreco = int.Parse(dgProdutos.CurrentRow.Cells[5].Value.ToString());
                    subitotal = int.Parse(lblSubitotal.Text) - rowPreco;
                    dgProdutos.Rows.RemoveAt(rowProduto);
                    lblSubitotal.Text = subitotal.ToString();
                    dgProdutos.ClearSelection();
                 }
                 catch (Exception erro) { }
             }
             else
             {
                 try
                 {
                    int rowProduto = dgServicos.CurrentCell.RowIndex;
                    int rowPreco = int.Parse(dgServicos.CurrentRow.Cells[2].Value.ToString());
                    subitotal = int.Parse(lblSubitotal.Text) - rowPreco;
                    dgServicos.Rows.RemoveAt(rowProduto);
                    lblSubitotal.Text = subitotal.ToString();
                    dgServicos.ClearSelection();
                }
                 catch (Exception erro) { }
             }
        }
    }
}
