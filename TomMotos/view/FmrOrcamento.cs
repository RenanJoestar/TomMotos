using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TomMotos.Classes;

namespace TomMotos.view
{
    public partial class FmrOrcamento : Form
    {
        Fmrcaixa lp;
        public FmrOrcamento(Fmrcaixa lpp)
        {
            InitializeComponent();
            lp = lpp;
        }

        private void FmOrcamento_Load(object sender, EventArgs e)
        {
            VendaDAO VendaDAO = new VendaDAO();
            dgOrcamento.DataSource = VendaDAO.listarOrcamento();
        }

        private void dgOrcamento_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            /*lp.dgProdutos.Text = dgOrcamento.CurrentRow.Cells.Value[0].ToString();
            lp.txtIdProduto.Focus();
            Fmrcaixa fmrCx = new Fmrcaixa();
            fmrCx.Show();*/
        }

        private void dgOrcamento_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
