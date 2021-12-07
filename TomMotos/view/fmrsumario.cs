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
using Microsoft.Win32;

namespace TomMotos
{
    public partial class Fmrsumario : Form
    {
        Fmrcaixa fmrcx = new Fmrcaixa();
        public Fmrsumario()
        {
            InitializeComponent();
        }
        public void AbrirFormNoPanel<Forms>() where Forms : Form, new()
        {
            Form formulario;
            formulario = Panel.Controls.OfType<Forms>().FirstOrDefault();
            Panel.Controls.Clear();
            if (formulario == null)
            {
                Panel.Controls.Clear();
                formulario = new Forms();
                formulario.TopLevel = false;
                Panel.Controls.Add(formulario);
                formulario.Show();
                formulario.BringToFront();
            }
            else
            {
                if (formulario.WindowState == FormWindowState.Minimized)
                {
                    formulario.WindowState = FormWindowState.Normal;
                    formulario.BringToFront();
                }
            }
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
         
          //Fmrsumariocadastro fmrsumariocadastro = new Fmrsumariocadastro();
          //fmrsumariocadastro.Show();
        }

        private void alowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Fmrcliente Fmrcliente = new Fmrcliente();
            // Fmrcliente.Show();
           // this.Hide();

        }
        private void cargoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fmrcargo fmrcargo = new Fmrcargo();
            fmrcargo.Show();
            //this.Hide();
        }

        private void fornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fmrfornecedor fmrfornecedor = new Fmrfornecedor();
            fmrfornecedor.Show();
           // this.Hide();
        }

        private void funcionarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fmrfuncionario fmrfuncionario = new Fmrfuncionario();
            fmrfuncionario.Show();
           // this.Hide();
        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fmrproduto fmrproduto = new Fmrproduto();
            fmrproduto.Show();
            //this.Hide();
        }

        private void veiculoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fmrveiculo fmrveiculo = new Fmrveiculo();
            fmrveiculo.Show();
           // this.Hide();
        }
        private void logFornecimentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmlogFornecimento frmlogFornecimento = new FrmlogFornecimento();
            frmlogFornecimento.Show();
            //this.Hide();
        }

        private void Fmrsumario_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void caixaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void orçamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //FmrOrcamento fmrOrc = new FmrOrcamento(null);
         //   fmrOrc.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel<Fmrcliente>();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel<Fmrveiculo>();
        }

     
        private void BT_CARGO_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel<Fmrcargo>();
        }

        private void BT_FUNCIONARIO_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel<Fmrfuncionario>();
        }

        private void BT_FORNECEDOR_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel<Fmrfornecedor>();
        }

        private void BT_PRODUTO_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel<Fmrproduto>();
        }

        private void BT_ORCAMENTO_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel<FmrOrcamento>();
            // Preciso de ajuda nisso aqui ^^ -José

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Panel.Controls.Clear();
        }

        private void BT_LOG_FORNECIMENTO_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel<FrmlogFornecimento>();
        }

        private void btnVendas_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel<FmrVenda>();
        }

        private void btnDevedores_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel<FmrDevedores>();
        }

        private void btnCaixa_Click(object sender, EventArgs e)
        {
            if (fmrcx.Visible == true) try { fmrcx.WindowState = FormWindowState.Maximized; } catch { }
            else try { fmrcx.Show(); } catch { fmrcx = new Fmrcaixa(); fmrcx.Show(); }
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Bem Vindo ao TOM MOTOS!");
        }

        private void X_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTN_GERENCIAMENTO_Click(object sender, EventArgs e)
        {
            if(lbl_gerenciamentoeconsulta.Text != "GERENCIAMENTO")
            {
                panel_botoes_gerenciamento.Visible = true;
                lbl_gerenciamentoeconsulta.Text = "GERENCIAMENTO";
                panel_botoes_consulta.Visible = false;
                Panel.Controls.Clear();

            }       
            else
            {
                panel_botoes_gerenciamento.Visible = false;
                lbl_gerenciamentoeconsulta.Text = null;
                Panel.Controls.Clear();
            }
            
        }

        private void BTN_CONSULTA_Click(object sender, EventArgs e)
        {
            if (lbl_gerenciamentoeconsulta.Text != "CONSULTA")
            {
                panel_botoes_consulta.Visible = true;
                lbl_gerenciamentoeconsulta.Text = "CONSULTA";
                panel_botoes_gerenciamento.Visible = false;
                Panel.Controls.Clear();
            }
            else
            {
                panel_botoes_consulta.Visible = false;
                lbl_gerenciamentoeconsulta.Text = "";
                Panel.Controls.Clear();
            }
        }

        private void Fmrsumario_Load(object sender, EventArgs e)
        {
            lbl_gerenciamentoeconsulta.Text = "";

            try
            {
                FmrConfig config = new FmrConfig();
                RegistryKey key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\TomMotos");

                try { this.BackgroundImage = Image.FromFile(key.GetValue("localImg").ToString()); } catch { } // SE DER ERRO É SÓ MARCAR A CHECKBOX 
                try { if (key.GetValue("estiloImagem").ToString() == "ImageLayout.Stretch") this.BackgroundImageLayout = ImageLayout.Stretch; } catch { }// DO VISUAL STUDIO SÓ AVISA QUE NÃO FOI)

                    // VERIFICA SE EXISTE UM VALOR NO REGEDIT
                if (key.GetValue("nomeEmail") == null || key.GetValue("senhaEmail") == null ||
                    key.GetValue("nomeEmail").ToString() == "" || key.GetValue("senhaEmail").ToString() == "") {

                    DialogResult dialogResult = MessageBox.Show("Nenhum email configurado\nDeseja configura-lo?", "Aviso",
                                                MessageBoxButtons.YesNo,
                                                MessageBoxIcon.Exclamation);
                    if (dialogResult == DialogResult.Yes) config.Show();
                }
            }
            catch { }
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            FmrConfig config = new FmrConfig();
            config.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
