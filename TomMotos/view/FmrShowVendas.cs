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
using TomMotos.Model;

namespace TomMotos.view
{
    public partial class FmrShowVendas : Form
    {
        FmrVenda func;
        FiltroDAO busca = new FiltroDAO();
        public FmrShowVendas(FmrVenda fun)
        {
            InitializeComponent();
            func = fun;
        }

        private void FmrShowFuncionarios_Load(object sender, EventArgs e)
        {
            try
            {

                dataGridView1.DataSource = busca.Exibir();
            }
            catch (Exception erro)
            { MessageBox.Show(erro.Message); }
            
            /*string finalSQL = "id_venda = " + func.textBox1.Text.ToString();
            FiltroModel.campoWhere = finalSQL;*/
            
        }
    }
}
