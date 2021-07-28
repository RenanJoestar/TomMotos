using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TomMotos.view
{
    public partial class Fmrsumariocadastro : Form
    {
        public Fmrsumariocadastro()
        {
            InitializeComponent();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            fmrcliente Fmrcliente = new fmrcliente();
            Fmrcliente.Show();
        }

        private void btnFuncionario_Click(object sender, EventArgs e)
        {
            Fmrfuncionario fmrfuncionario = new Fmrfuncionario();
            fmrfuncionario.Show();
        }

        private void btnFornecedor_Click(object sender, EventArgs e)
        {
            Fmrfornecedor fmrfornecedor = new Fmrfornecedor();
            fmrfornecedor.Show();
        }

        private void btnProduto_Click(object sender, EventArgs e)
        {
            Fmrproduto fmrproduto = new Fmrproduto();
            fmrproduto.Show();
        }
    }
}
