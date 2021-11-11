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
        string[] item = new string[7];
        Fmrcaixa lp;
        string id_orc;
        
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
            try
            {
                Fmrcaixa fmrCx = new Fmrcaixa();
                fmrCx.Show();
                item[0] = "2";//dgOrcamento.CurrentRow.Cells[0].Value.ToString();
                item[1] = "2";
                item[2] = "2";
                item[3] = "2";
                item[4] = "2";
                item[5] = "2";
                lp.dgProdutos.Rows.Add((item));
                lp.txtIdProduto.Text = "2";
                
            }
            catch (Exception erro) { MessageBox.Show("Test "+erro);}
        }

        private void dgOrcamento_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
