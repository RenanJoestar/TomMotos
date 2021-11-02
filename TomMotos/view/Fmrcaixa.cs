using MySql.Data.MySqlClient;
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
        string[] item = new string[7];
        List<string> nota = new List<string>();
        string id_produto, nome_produto,id_venda;
        int itens = 0, servicos = 0;
        CaixaDAO vendaDAO = new CaixaDAO();
        ProdutoUsadoDAO produtoDAO = new ProdutoUsadoDAO();
        CaixaModel objVenda = new CaixaModel();
        ProdutoUsadoModel objProduto = new ProdutoUsadoModel();
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
            label12.BackColor = Color.Transparent;
            lblSubitotal.Text = 0.ToString();            
            dgProdutos.Columns[2].Width=200;
            dgServicos.Columns[1].Width = 243;
        }

        private void btnFinalizaVenda_Click(object sender, EventArgs e)
        {
            FinalizarVenda(); 
        }
        public void FinalizarVenda() {
            string descricao = "", idVenda = "";
            double valorMaoDeObra = 0;

            try
            {
                for (int i = 0; i < dgServicos.Rows.Count - 1; i++)
                {
                    descricao = descricao + " | " + dgServicos.Rows[i].Cells[1].Value.ToString();
                    valorMaoDeObra = valorMaoDeObra + int.Parse(dgServicos.Rows[i].Cells[2].Value.ToString());
                }
            }
            catch (Exception) { }

            objVenda.descricao = descricao.ToUpper();
            objVenda.validade_orcamento_servico = DateTime.Now;
            objVenda.preco_mao_de_obra = valorMaoDeObra;
            if (txtdesc.Text == "") objVenda.desconto = 0;
            else objVenda.desconto = double.Parse(txtdesc.Text);
            objVenda.total = double.Parse(lblSubitotal.Text);
            if (lbl_buscarCliente.Text != "" && lbl_buscarCliente.Text != "(id)") CaixaModel.fk_cliente_id = lbl_buscarCliente.Text;
            else CaixaModel.fk_cliente_id = null;// cliente null
            if (lbl_BuscarVeiculo.Text != "" && lbl_BuscarVeiculo.Text != "(id)") CaixaModel.fk_veiculo_id = lbl_BuscarVeiculo.Text; // veiculo null
            else CaixaModel.fk_veiculo_id = null; // veiculo null
            vendaDAO.cadastrar(objVenda);

            idVenda = vendaDAO.listarUltimaVenda();
            try
            {
                for (int i = 0; i < dgProdutos.Rows.Count - 1; i++)
                {

                    objProduto.quantidade_produto_usado = double.Parse(dgProdutos.Rows[i].Cells[3].Value.ToString());
                    objProduto.fk_produto_id = int.Parse(dgProdutos.Rows[i].Cells[1].Value.ToString());
                    objProduto.fk_venda_id = int.Parse(idVenda);
                    objProduto.validade_da_garantia_produto = DateTime.Now;

                    produtoDAO.cadastrar(objProduto);

                }
            }
            catch (Exception) { }

            vendaDAO.mudarStatusVenda(idVenda, true);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            EnviarEmail();
        }
        public void EnviarEmail() {
            string htmlString = getHtml(dgProdutos, dgServicos);
            Email(htmlString);
        }
        public string getHtml(DataGridView grid, DataGridView grid2)
        {
            try
            {                
                string messageBody = "<head> <meta charset = 'utf-8' /> </head> <p> SEU COMPROVANTE DA TOMMOTOS: </p><br><br>", messageB = "", total="";
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
                    messageBody += htmlTdStart + "DESCONTO.(%)" + htmlTdEnd;
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
                if(txtdesc.Text !="")total += htmlTdStart + "DESCONTO FINAL(%)" + htmlTdEnd;
                total += htmlTdStart + "TOTAL(R$)" + htmlTdEnd;
                total += htmlHeaderRowEnd;

                total = total + htmlTrStart;
                total = total + htmlTdStart + DateTime.Now.ToString() + htmlTdEnd;
                if (txtdesc.Text != "") total = total + htmlTdStart + txtdesc.Text.ToString() + htmlTdEnd;
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
                    messageBody = messageBody + htmlTdStart + grid.Rows[i].Cells[6].Value + htmlTdEnd;
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
                string emailRementente = "tommotos2020@gmail.com", senhaRementente = "972494264", emailDestinatario = CaixaModel.emailCliente;
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
                MessageBox.Show("Test "+ erro.Message);
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
            if (txtdesc.Text != "" && lblSubitotal.Text != "0")
            {
                desconto = double.Parse(lblSubitotal.Text) * (double.Parse(txtdesc.Text) / 100);
                lblSubitotal.Text = (double.Parse(lblSubitotal.Text) - desconto).ToString();               
                txtdesc.Enabled = false;
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            lblSubitotal.Text = (double.Parse(lblSubitotal.Text) + desconto).ToString();
            desconto = 0;
            txtdesc.Enabled = true;
        }

        private void txtIdProduto_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.KeyData == Keys.F2) {
                PesquisarProduto();
            }
         
            if (e.KeyData == Keys.F6) txtqtd.Focus();
            if (e.KeyData == Keys.F5) {
                IrParaFinalizar();
            }

            if (e.KeyData == Keys.Enter)
            {
                double valor_produto, valor_total, total, desconto;
                if (lblSubitotal.Text == "") total = 0;
                else total = double.Parse(lblSubitotal.Text);
                string select = "select id_produto, descricao_produto, marca_produto quantidade_produto, valor_produto, imagem_produto  from tb_produto where id_produto = " + txtIdProduto.Text.ToString();
                MySqlCommand executacmdsql = new MySqlCommand(select, conexao);

                MySqlDataAdapter da = new MySqlDataAdapter(executacmdsql);

                DataSet ds = new DataSet();
                try
                {
                    da.Fill(ds);

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

                    if (txt_desconto_pro.Text != "")
                    {
                        double desc;
                        desc = (valor_produto * int.Parse(txtqtd.Text));
                        desconto = desc * double.Parse(txt_desconto_pro.Text) / 100;
                        desconto = desc - desconto;
                        item[6] = desconto.ToString();
                        lblSubitotal.Text = (double.Parse(lblSubitotal.Text) + desconto).ToString();

                    }
                    else
                    {
                        txt_desconto_pro.Text = "0";
                        total = total + (valor_produto * int.Parse(txtqtd.Text));
                        lblSubitotal.Text = total.ToString();
                        valor_total = valor_produto * double.Parse(txtqtd.Text);
                        item[6] = valor_total.ToString();
                    }


                    if (itens == 0) itens = 1;
                    else itens += 1;

                    item[0] = itens.ToString();
                    item[1] = id_produto;
                    item[2] = nome_produto;
                    item[3] = txtqtd.Text;
                    item[4] = valor_produto.ToString();
                    item[5] = txt_desconto_pro.Text;
                    dgProdutos.Rows.Add((item));

                    txtIdProduto.Text = "";
                    txtqtd.Text = "1";
                    txt_desconto_pro.Text = "";

                }
                catch (Exception erro)
                {
                    MessageBox.Show("PRODUTO NÃO ENCONTRADO!!");
                }
            }
        }

        private void Fmrcaixa_KeyDown(object sender, KeyEventArgs e)
        {
            //MessageBox.Show("Test " + e.KeyValue.ToString());
            //if (e.KeyValue == )
            if (e.KeyData == Keys.F2)
            {
                PesquisarProduto();
            }
        }

        private void txtqtd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F2)
            {
                PesquisarProduto();
            }
            if (e.KeyData == Keys.Enter) txtIdProduto.Focus();
            if (e.KeyData == Keys.F5)
            {
                IrParaFinalizar();
            }
            //MessageBox.Show("Test " + e.KeyValue.ToString());
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Fmrcaixa_Shown(object sender, EventArgs e)
        {
            txtIdProduto.Focus();
        }

        private void txt_pmo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F2)
            {
                PesquisarProduto();
            }
            if (e.KeyData == Keys.F5)
            {
                IrParaFinalizar();
            }
            if (e.KeyData == Keys.Enter)
            {
                double preco_servico = 0, pt;

                if (txt_pmo.Text != "" || txtDescServ.Text != "")
                {
                    try
                    {
                        if (servicos == 0) servicos = 1;
                        else servicos += 1;
                        preco_servico = int.Parse(txt_pmo.Text);
                        pt = double.Parse(lblSubitotal.Text);
                        SERVICO[1] = txtDescServ.Text.ToString();
                        SERVICO[2] = txt_pmo.Text.ToString();

                        SERVICO[0] = servicos.ToString();
                        dgServicos.Rows.Add((SERVICO));
                        pt += preco_servico;
                        lblSubitotal.Text = pt.ToString();
                    }
                    catch (Exception erro)
                    {
                        MessageBox.Show(erro.ToString());
                    }
                }
                else MessageBox.Show("VERIFIQUE SE EXISTE CAMPOS EM BRANCOS");
            }
        }

        private void btn_buscarVeiculo_Click(object sender, EventArgs e)
        {
            try
            {
                CaixaModel.valorPesquisa = "veiculo";
                FmrVeiculo_Cliente fmrVC = new FmrVeiculo_Cliente( this);
                fmrVC.Show();
            }
            catch (Exception erro) {
                MessageBox.Show(" "+erro.Message);
            }
        }

        private void btn_BuscarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                CaixaModel.valorPesquisa = "cliente";
                FmrVeiculo_Cliente fmrVC = new FmrVeiculo_Cliente( this);
                fmrVC.Show();
            }
            catch (Exception erro)
            {
                MessageBox.Show(" " + erro.Message);
            }
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            lbl_BuscarVeiculo.Text = CaixaModel.fk_veiculo_id.ToString();
        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            IrParaFinalizar();
        }
        public void IrParaFinalizar() {
            if (lblSubitotal.Text != "0")
            {
                FmrFinalizar_venda destino = new FmrFinalizar_venda(this, this);
                destino.Show();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SalvarPdf();
        }

        private void txt_desconto_pro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F2)
            {
                PesquisarProduto();
            }
            if (e.KeyData == Keys.F5)
            {
                IrParaFinalizar();
            }
        }

        private void txtPrU_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F2)
            {
                PesquisarProduto();
            }
            if (e.KeyData == Keys.F5)
            {
                IrParaFinalizar();
            }
        }

        private void txtDescServ_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F2)
            {
                PesquisarProduto();
            }
            if (e.KeyData == Keys.F5)
            {
                IrParaFinalizar();
            }
        }

        private void txtdesc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F2)
            {
                PesquisarProduto();
            }
            if (e.KeyData == Keys.F5)
            {
                IrParaFinalizar();
            }
        }

        private void btn_buscarVeiculo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F2)
            {
                PesquisarProduto();
            }
            if (e.KeyData == Keys.F5)
            {
                IrParaFinalizar();
            }
        }

        private void btn_BuscarCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F2)
            {
                PesquisarProduto();
            }
            if (e.KeyData == Keys.F5)
            {
                IrParaFinalizar();
            }
        }

        private void btnPesquisarProduto_Click(object sender, EventArgs e)
        {
            PesquisarProduto();
        }
        public void PesquisarProduto() {
            try
            {
                FmrListProdutos fmrLP = new FmrListProdutos(this);
                fmrLP.Show();
            }
            catch (Exception erro)
            {
                MessageBox.Show(" " + erro.Message);
            }
        }

        private void dgProdutos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F2)
            {
                PesquisarProduto();
            }
            if (e.KeyData == Keys.F5)
            {
                IrParaFinalizar();
            }
            if (e.KeyData == Keys.Delete) {
                
                Excluir_Produto();

            }
        }

        public void SalvarPdf() {
            try
            {
                string html = getHtml(dgProdutos, dgServicos);
                string nomePDF = "venda" + vendaDAO.listarUltimaVenda() + ".pdf";

                criarPDF(html, nomePDF);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.ToString());
            }
        }

        private void dgServicos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F2)
            {
                PesquisarProduto();
            }
            if (e.KeyData == Keys.F5)
            {
                IrParaFinalizar();
            }
            if (e.KeyData == Keys.Delete)
            {

                Excluir_Produto();

            }
        }

        private void criarPDF(string html, string nomePDF)
        {
            string caminhoPDF = "E:/" + nomePDF;
            var conteudoHTML = String.Format(html, DateTime.Now);
            var htmlToPdf = new NReco.PdfGenerator.HtmlToPdfConverter();
            htmlToPdf.GeneratePdf(conteudoHTML, null, caminhoPDF);
        }

        public void Excluir_Produto() {
            int subitotal = int.Parse(lblSubitotal.Text);
            if (dgProdutos.SelectedCells.Count > 0)
            {
                if (dgProdutos.CurrentRow.Cells[5].Value != null)
                {
                    try
                    {
                        var result = MessageBox.Show("Deseja deletar o Item "+ dgProdutos.CurrentRow.Cells[0].Value.ToString()+"?", "Deletar",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Information);
                        if (result == DialogResult.Yes)
                        {
                            int rowProduto = dgProdutos.CurrentCell.RowIndex;
                            int rowPreco = int.Parse(dgProdutos.CurrentRow.Cells[5].Value.ToString());
                            subitotal = int.Parse(lblSubitotal.Text) - rowPreco;
                            dgProdutos.Rows.RemoveAt(rowProduto);
                            lblSubitotal.Text = subitotal.ToString();
                            dgProdutos.ClearSelection();
                        }
                      
                        
                    }
                    catch (Exception erro)
                    {
                        MessageBox.Show("" + erro.Message);
                    }
                }
            }            

        }
        public void Excluir_Servico()
        {
            int subitotal = int.Parse(lblSubitotal.Text);
            if (dgServicos.SelectedCells.Count > 0)
            {
                if (dgServicos.CurrentRow.Cells[5].Value != null)
                {
                    try
                    {
                        var result = MessageBox.Show("Deseja deletar o serviço " + dgServicos.CurrentRow.Cells[0].Value.ToString() + "?", "Deletar",
                                                     MessageBoxButtons.YesNo,
                                                     MessageBoxIcon.Information);
                        if (result == DialogResult.Yes)
                        {
                            int rowProduto = dgServicos.CurrentCell.RowIndex;
                            int rowPreco = int.Parse(dgServicos.CurrentRow.Cells[2].Value.ToString());
                            subitotal = int.Parse(lblSubitotal.Text) - rowPreco;
                            dgServicos.Rows.RemoveAt(rowProduto);
                            lblSubitotal.Text = subitotal.ToString();
                            dgServicos.ClearSelection();
                        }
                    }
                    catch (Exception erro)
                    {
                        MessageBox.Show("" + erro.Message);
                    }
                }
            }
           

        }
        private void BtnExcluir_item_Click(object sender, EventArgs e)
        {
        }
    }
}
