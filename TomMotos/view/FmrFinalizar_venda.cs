using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TomMotos.Conexao;
using TomMotos.Model;

namespace TomMotos.view
{
    public partial class FmrFinalizar_venda : Form
    {
        public static Form globalForm;
        MySqlConnection conexao = ConnectionFactory.getConnection();
        Fmrcaixa fp;
        Fmrcaixa fz;

        public FmrFinalizar_venda(Fmrcaixa f, Fmrcaixa ff)
        {
            InitializeComponent();
            fp = f;
            fz = ff;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void FmrFinalizar_venda_Load(object sender, EventArgs e)
        {
            carregarEmails();
            lblsubtotal.Text= fp.lblSubitotal.Text; 
        }
        private void carregarEmails()
        {
            if (CaixaModel.fk_cliente_id != null)
            {
                MySqlConnection cn = new MySqlConnection();
                cn = conexao;
                cn.Open();
                MySqlCommand com = new MySqlCommand();
                com.Connection = cn;
                com.CommandText = "select nome_email, id_usuario from tb_usuario inner join tb_email on tb_usuario.id_usuario = tb_email.id_email where fk_cliente_id = " + CaixaModel.fk_cliente_id;
                MySqlDataReader dr = com.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                cbxEmails.DisplayMember = "nome_email";
                cbxEmails.DataSource = dt;
                cbxEmails.Text = null;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CalcularTroco();
        }
        public void CalcularTroco() {

            txtTroco.Text = (int.Parse(txtDinheiro.Text) + int.Parse(txtDebito.Text) + int.Parse(txt_credito.Text) + int.Parse(txtPix.Text) - int.Parse(lblsubtotal.Text)).ToString();
            txtFaltaPagar.Text = "";
            if (int.Parse(txtTroco.Text) < 0)
            {
                txtFaltaPagar.Text = txtTroco.Text;
                txtTroco.Text = "";
            }
            txtValorPago.Text = (int.Parse(txtDinheiro.Text) + int.Parse(txtDebito.Text) + int.Parse(txt_credito.Text) + int.Parse(txtPix.Text)).ToString();
        }
        public void SalvarPdf() {
            fz.SalvarPdf();
                     
        }
        public void EnviarEmail()
        {
            fz.EnviarEmail();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            CaixaModel.emailCliente = cbxEmails.Text;
            try
            {
                if (txtTroco.Text == "")
                {
                    MessageBox.Show("Verifique o valor Pago ", "Aviso",
                                                MessageBoxButtons.OK,
                                                MessageBoxIcon.Exclamation);
                    return;
                }
                
                if (cbxEmails.Text == "")
                {
                    var result = MessageBox.Show("Deseja enviar Comprovante no email? ", "Comprovante",
                                                MessageBoxButtons.YesNo,
                                                MessageBoxIcon.Information);
                    if (result == DialogResult.Yes)
                    {
                        MessageBox.Show("Escolha o Email que deseja enviar!");
                        return;
                    }
                    else
                    {
                        fz.FinalizarVenda();
                        fz.SalvarPdf();
                    }
                }
                else
                {
                    fz.FinalizarVenda();
                    fz.SalvarPdf();
                    fz.EnviarEmail();
                }
                MessageBox.Show("Foi");
                CaixaModel.vendaFinalizada = true;
                this.Close();
            }
            catch (Exception erro) {
                MessageBox.Show("Erro "+erro.Message);
            }
        }

        private void txtDinheiro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13) {
                CalcularTroco();
                btnOk.Focus();
            }
        }

        private void txtDebito_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                CalcularTroco();
                btnOk.Focus();
            }
        }

        private void txt_credito_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                CalcularTroco();
                btnOk.Focus();
            }
        }

        private void txtPix_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                CalcularTroco();
                btnOk.Focus();
            }
        }
    }
}
