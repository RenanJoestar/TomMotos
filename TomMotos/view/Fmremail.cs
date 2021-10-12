using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
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

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
            string campo = cbxBuscar.Text.ToString() + "_email";
            FiltroModel.filtro = @"select * from tb_email where " + campo.ToLower() + " like " + "'%" + txtBuscar.Text.ToString() + "%' and fk_usuario_id = "+txt_id.Text.ToString();            
            FiltroDAO dao = new FiltroDAO();
            dgEmail.DataSource = dao.buscaCargo(); 
            }
            catch (Exception erro) { MessageBox.Show("Ouve um Erro " + erro); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_email.Text != "")
                {
                    string chars = "abcdefghjkmnpqrstuvwxyz023456789";
                    string pass = "";
                    Random random = new Random();
                    for (int f = 0; f < 6; f++)
                    {
                        pass = pass + chars.Substring(random.Next(0, chars.Length - 1), 1);
                    }
                    MessageBox.Show(pass);                   

                    MailMessage mailMessage = new MailMessage("EMAIL REMETENTE", "EMAIL DESTINATARIO");

                    mailMessage.Subject = "Login do Site TomMotos";
                    mailMessage.IsBodyHtml = true;
                    mailMessage.Body = "<p>Site: https//:tommostos.com.br</p> <br>"+ "<p> Email:" + txt_email.Text.ToString() + "</p><p> Senha:" + pass + " </p>";
                    mailMessage.SubjectEncoding = Encoding.GetEncoding("UTF-8");
                    mailMessage.BodyEncoding = Encoding.GetEncoding("UTF-8");

                    SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);

                    smtpClient.UseDefaultCredentials = false;
                    smtpClient.Credentials = new NetworkCredential("EMAIL REMETENTE", "SENHA DO EMAIL REMETENTE");
                    smtpClient.EnableSsl = true;
                    smtpClient.Send(mailMessage);
                    EmailModel obj = new EmailModel();
                    EmailModel.id_usuario = txt_id.Text;
                    obj.senha_usuario = pass;
                    EmailDAO Cadastrosenha = new EmailDAO();
                    Cadastrosenha.cadastrarSenha(obj);
                }
                else MessageBox.Show("SELECIONE UM EMAIL QUE DESEJA ENVIAR A SENHA","ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch(Exception erro) {
                MessageBox.Show("Erro"+ erro);
            }



        }

        private void lblNome_Click(object sender, EventArgs e)
        {

        }
    }
}
