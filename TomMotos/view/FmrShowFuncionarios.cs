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
    public partial class FmrShowFuncionarios : Form
    {
        FmrVenda func;
        public FmrShowFuncionarios(FmrVenda fun)
        {
            InitializeComponent();
            func = fun;
        }

        private void FmrShowFuncionarios_Load(object sender, EventArgs e)
        {
            FiltroDAO busca = new FiltroDAO();
            string finalSQL = "id_venda = " + func.textBox1.Text.ToString();
            FiltroModel.campoWhere = finalSQL;
            dataGridView1.DataSource= busca.buscaGrupoFuncionario();
        }
    }
}
