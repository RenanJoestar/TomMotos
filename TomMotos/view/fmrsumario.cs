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
            contextMenuStrip1.Show();
            //Fmrsumariocadastro fmrsumariocadastro = new Fmrsumariocadastro();
            //fmrsumariocadastro.Show();
        }

        private void alowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fmrsumariocadastro fmrsumariocadastro = new Fmrsumariocadastro();
            fmrsumariocadastro.Show();

        }
    }
}
