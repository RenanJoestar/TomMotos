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
    public partial class FmrDevedores : Form
    {
        VendaDAO VendaDAO = new VendaDAO();
        public FmrDevedores()
        {
            InitializeComponent();
        }

        private void FmrDevedores_Load(object sender, EventArgs e)
        {
            dgOrcamento.DataSource = VendaDAO.listarTodos(true); //Puxa todos os orçamentos
        }
    }
}
