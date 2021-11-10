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
      
        private void btnCadastro_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Show(PointToScreen(btnCadastro.Location));
          //Fmrsumariocadastro fmrsumariocadastro = new Fmrsumariocadastro();
          //fmrsumariocadastro.Show();
        }

        private void alowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fmrcliente Fmrcliente = new Fmrcliente();
            Fmrcliente.Show();
            this.Hide();

        }
        private void cargoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fmrcargo fmrcargo = new Fmrcargo();
            fmrcargo.Show();
            this.Hide();
        }

        private void fornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fmrfornecedor fmrfornecedor = new Fmrfornecedor();
            fmrfornecedor.Show();
            this.Hide();
        }

        private void funcionarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fmrfuncionario fmrfuncionario = new Fmrfuncionario();
            fmrfuncionario.Show();
            this.Hide();
        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fmrproduto fmrproduto = new Fmrproduto();
            fmrproduto.Show();
            this.Hide();
        }

        private void veiculoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fmrveiculo fmrveiculo = new Fmrveiculo();
            fmrveiculo.Show();
            this.Hide();
        }
        private void logFornecimentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmlogFornecimento frmlogFornecimento = new FrmlogFornecimento();
            frmlogFornecimento.Show();
            this.Hide();
        }

        private void Fmrsumario_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void caixaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCaixa_Click(object sender, EventArgs e)
        {
            Fmrcaixa fmrcx = new Fmrcaixa();
            fmrcx.Show();
        }

        private void orçamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FmrOrcamento fmrOrc = new FmrOrcamento(null);
            fmrOrc.Show();
        }
    }
}
