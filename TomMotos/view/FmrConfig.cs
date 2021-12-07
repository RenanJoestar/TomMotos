using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TomMotos.view
{
    public partial class FmrConfig : Form
    {
        string localizacaoImagem = "", localizacaoPDF = "", estiloImagemCXB = "";
        RegistryKey key = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\TomMotos");
        public FmrConfig()
        {
            InitializeComponent();
        }

        private void btnAcharImg_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog1 = new OpenFileDialog();
                openFileDialog1.Filter = "Image Files(*.BMP;*.JPG;*.PNG)|*.BMP;*.JPG;*.PNG" +
                "|All files(*.*)|*.*";
                openFileDialog1.CheckFileExists = true;
                openFileDialog1.Multiselect = false;
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    localizacaoImagem = openFileDialog1.FileName;
                    lblLocalImg.Text = localizacaoImagem;
                    lblLocalImg.ForeColor = Color.Green;
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Ouve um erro " + erro);
            }
        }

        private void btnLimparImg_Click(object sender, EventArgs e)
        {
            localizacaoImagem = "";
            lblLocalImg.Text = "Nenhuma imagem configurada."; 
            lblLocalImg.ForeColor = Color.Red;
        }

        private void btnAcharPDF_Click(object sender, EventArgs e)
        {
            try
            {
                FolderBrowserDialog folderDialog1 = new FolderBrowserDialog();
                if (folderDialog1.ShowDialog() == DialogResult.OK)
                {
                    localizacaoPDF = folderDialog1.SelectedPath;
                    lblLocalPDF.Text = localizacaoPDF;
                    lblLocalPDF.ForeColor = Color.Green;
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Ouve um erro " + erro);
            }
        }

        private void brnAplicar_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string senha = txtSenha.Text;
            string localImg = localizacaoImagem;
            string localPDF = localizacaoPDF;
            string estiloImagem = estiloImagemCXB;

            try
            {
                // VERIFICA SE EXISTE UM VALOR NO REGEDIT
                key.SetValue("nomeEmail", email);
                key.SetValue("senhaEmail", senha);
                key.SetValue("localImg", localImg);
                key.SetValue("localPDF", localPDF);
                key.SetValue("estiloImagem", estiloImagem);
                key.Close();
                Application.Restart();
            }
            catch (Exception erro) { MessageBox.Show(erro.ToString()); }
        }

        private void btbCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimparPDF_Click(object sender, EventArgs e)
        {
            localizacaoPDF = "";
            lblLocalPDF.Text = "Nenhum local configurado.";
            lblLocalPDF.ForeColor = Color.Red;
        }

        private void fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cb_esticarimagem_CheckedChanged(object sender, EventArgs e)
        {
            estiloImagemCXB = cb_esticarimagem.Checked ? "ImageLayout.Stretch" : "ImageLayout.Center";
        }

        private void mostrarsenha_CheckedChanged(object sender, EventArgs e)
        {
            txtSenha.PasswordChar = mostrarsenha.Checked ? '\0' : '*';
        }
        
        private void FmrConfig_Load(object sender, EventArgs e)
        {
            this.ShowInTaskbar = false;
            lblLocalImg.Text = "Nenhuma imagem configurada.";
            lblLocalImg.ForeColor = Color.Red;
            lblLocalPDF.Text = "Nenhum local configurado.";
            lblLocalPDF.ForeColor = Color.Red;

            if (key.GetValue("nomeEmail") != null)
            {
                txtEmail.Text = key.GetValue("nomeEmail").ToString();
                txtSenha.Text = key.GetValue("senhaEmail").ToString();

                if (key.GetValue("localImg").ToString() != "") // LOCAL IMG
                {
                    lblLocalImg.Text = key.GetValue("localImg").ToString();
                    localizacaoImagem = lblLocalImg.Text;
                    lblLocalImg.ForeColor = Color.Green;
                }

                if (key.GetValue("localPDF").ToString() != "") // LOCAL PDF
                {
                    lblLocalPDF.Text = key.GetValue("localPDF").ToString();
                    localizacaoPDF = lblLocalPDF.Text;
                    lblLocalPDF.ForeColor = Color.Green;
                }

                if (key.GetValue("estiloImagem").ToString() != "") // ESTILO DE IMAGEM
                {
                    if (key.GetValue("estiloImagem").ToString() == "ImageLayout.Stretch") cb_esticarimagem.Checked = true;
                    localizacaoPDF = lblLocalPDF.Text;
                    lblLocalPDF.ForeColor = Color.Green;
                }
            }
        }
    }
}
