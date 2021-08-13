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
                obj.nome = txt_email.Text.ToUpper();

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

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                EmailModel obj = new EmailModel();
                obj.nome = txt_email.Text.ToUpper();

                EmailDAO Alterar = new EmailDAO();

                Alterar.alterar(obj);

                dgEmail.DataSource = Alterar.ListarEmails();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro: " + erro);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                EmailModel obj = new EmailModel();
                obj.nome = txt_email.Text.ToUpper();

                EmailDAO Excluir = new EmailDAO();

                Excluir.Excluir(obj);

                dgEmail.DataSource = Excluir.ListarEmails();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro: " + erro);
            }

        }

        private void dgEmail_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string idEmail;
            idEmail = dgEmail.CurrentRow.Cells[0].Value.ToString();
            txt_email.Text = dgEmail.CurrentRow.Cells[1].Value.ToString();
            EmailModel.id_email = idEmail;
              
        }
    }
}
