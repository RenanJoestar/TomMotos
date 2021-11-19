using TomMotos.view;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TomMotos
{
    public partial class Fmrsumario : Form
    {
        public Fmrsumario()
        {
            InitializeComponent();
        }
        public void AbrirFormNoPanel<Forms>() where Forms : Form, new()
        {
            Form formulario;
            formulario = Panel.Controls.OfType<Forms>().FirstOrDefault();
            Panel.Controls.Clear();
            if (formulario == null)
            {
                Panel.Controls.Clear();
                formulario = new Forms();
                formulario.TopLevel = false;
                Panel.Controls.Add(formulario);
                formulario.Show();
                formulario.BringToFront();

            }
            else
            {
               
                if (formulario.WindowState == FormWindowState.Minimized)
                {
                    formulario.WindowState = FormWindowState.Normal;
                    formulario.BringToFront();
                }

            }

        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
         
          //Fmrsumariocadastro fmrsumariocadastro = new Fmrsumariocadastro();
          //fmrsumariocadastro.Show();
        }

        private void alowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Fmrcliente Fmrcliente = new Fmrcliente();
            // Fmrcliente.Show();
           // this.Hide();

        }
        private void cargoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fmrcargo fmrcargo = new Fmrcargo();
            fmrcargo.Show();
            //this.Hide();
        }

        private void fornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fmrfornecedor fmrfornecedor = new Fmrfornecedor();
            fmrfornecedor.Show();
           // this.Hide();
        }

        private void funcionarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fmrfuncionario fmrfuncionario = new Fmrfuncionario();
            fmrfuncionario.Show();
           // this.Hide();
        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fmrproduto fmrproduto = new Fmrproduto();
            fmrproduto.Show();
            //this.Hide();
        }

        private void veiculoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fmrveiculo fmrveiculo = new Fmrveiculo();
            fmrveiculo.Show();
           // this.Hide();
        }
        private void logFornecimentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmlogFornecimento frmlogFornecimento = new FrmlogFornecimento();
            frmlogFornecimento.Show();
            //this.Hide();
        }

        private void Fmrsumario_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void caixaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void orçamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //FmrOrcamento fmrOrc = new FmrOrcamento(null);
         //   fmrOrc.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel<Fmrcliente>();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel<Fmrveiculo>();
        }

     
        private void BT_CARGO_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel<Fmrcargo>();
        }

        private void BT_FUNCIONARIO_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel<Fmrfuncionario>();
        }

        private void BT_FORNECEDOR_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel<Fmrfornecedor>();
        }

        private void BT_PRODUTO_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel<Fmrproduto>();
        }

        private void BT_ORCAMENTO_Click(object sender, EventArgs e)
        {
            FmrOrcamento fmrOrc = new FmrOrcamento(null);
            fmrOrc.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Panel.Controls.Clear();
        }

        private void BT_LOG_FORNECIMENTO_Click(object sender, EventArgs e)
        {
            FrmlogFornecimento fmr = new FrmlogFornecimento();
            fmr.Show();
        }

        private void btnVendas_Click(object sender, EventArgs e)
        {
            FmrVenda frmVenda = new FmrVenda();
            frmVenda.Show();
        }

        private void btnDevedores_Click(object sender, EventArgs e)
        {
            FmrDevedores frmDev = new FmrDevedores();
            frmDev.Show();
        }

        private void btnCaixa_Click(object sender, EventArgs e)
        {
            Fmrcaixa fmrcx = new Fmrcaixa();
            fmrcx.Show();
        }
    }
}
