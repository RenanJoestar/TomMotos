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
    public partial class Fmremail : Form
    {
        public Fmremail()
        {
            InitializeComponent();
        }
        public Fmremail(string NOME)
        {
            InitializeComponent();
            lblNome.Text = NOME;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                EmailModel obj = new EmailModel();
                EmailModel.id = txt_id.Text;
                obj.nome = txt_email.Text;

                EmailDAO Cadastro = new EmailDAO();

                Cadastro.cadastrarEmail(obj);

                dgEmail.DataSource = Cadastro.ListarEmails();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro: " + erro);
            }
        }

        private void Fmremail_Load(object sender, EventArgs e)
        {
            EmailDAO Cadastro = new EmailDAO();
            dgEmail.DataSource = Cadastro.ListarEmails();
            txt_id.Text = EmailModel.id;
        }

        private void Fmremail_Activated(object sender, EventArgs e)
        {
            EmailDAO Cadastro = new EmailDAO();
            dgEmail.DataSource = Cadastro.ListarEmails();
            txt_id.Text = EmailModel.id;

        }
    }
}
