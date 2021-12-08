using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using TomMotos.Classes;

using TomMotos.Model;

namespace TomMotos.view
{
    public partial class Fmrendereco : Form
    {
        EnderecoDAO Cadastro = new EnderecoDAO();
        FiltroDAO Filtro = new FiltroDAO();
        public Fmrendereco()
        {
            InitializeComponent();
        }
        public Fmrendereco(string NOME)
        {
            InitializeComponent();
            lblNome.Text = NOME;

        }

        private void Fmrendereco_Load(object sender, EventArgs e)
        {
            dgEndereco.DataSource = Cadastro.ListarEndereco();
            txt_id.Text = EnderecoModel.id;
        }
        private void PegaJson()
        {
            try
            {
                if (txt_cep.Text != "     -" && txt_endereco.Text =="" && txt_bairro.Text =="" && txt_cidade.Text == "")
                {
                    HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://viacep.com.br/ws/"+txt_cep.Text+"/json/");
                    request.AllowAutoRedirect = false;

                    using (HttpWebResponse ChecaServidor = (HttpWebResponse)request.GetResponse())
                    {
                        using (Stream webStream = ChecaServidor.GetResponseStream())
                        {
                            if (webStream != null)
                            {
                                using (StreamReader responseReader = new StreamReader(webStream))
                                {
                                    string response = responseReader.ReadToEnd();
                                    response = Regex.Replace(response, "[{},]", string.Empty);
                                    response = response.Replace("\"", "");

                                    String[] substrings = response.Split('\n');

                                    int cont = 0;
                                    foreach (var substring in substrings)
                                    {
                                        if (cont == 1)
                                        {
                                                txt_cep.Focus();
                                        }

                                        //Logradouro
                                        if (cont == 2)
                                        {
                                            string[] valor = substring.Split(":".ToCharArray());
                                            txt_endereco.Text = valor[1];
                                        }


                                        //Bairro
                                        if (cont == 4)
                                        {
                                            string[] valor = substring.Split(":".ToCharArray());
                                            txt_bairro.Text = valor[1];
                                        }

                                        //Localidade (Cidade)
                                        if (cont == 5)
                                        {
                                            string[] valor = substring.Split(":".ToCharArray());
                                            txt_cidade.Text = valor[1];
                                            
                                        }

                                        cont++;
                                  }
                                }
                               }
                            }
                          }
                            txt_numero.Focus();
                     }
               
          }

            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
                txt_bairro.Text = "";
                txt_cidade.Text = "";
                txt_endereco.Text = "";
                txt_endereco.Focus();
            }

        }

    private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                EnderecoModel obj = new EnderecoModel();
                EnderecoModel.id = txt_id.Text;
                if (txt_cep.Text == "     -") obj.cep = null;
                else obj.cep = txt_cep.Text.ToUpper();
                obj.endereco = txt_endereco.Text.ToUpper();
                obj.bairro = txt_bairro.Text.ToUpper();
                obj.numero = txt_numero.Text.ToUpper();
                obj.cidade = txt_cidade.Text.ToUpper();

                EnderecoDAO Cadastro = new EnderecoDAO();

                Cadastro.cadastrarEndereco(obj);

                dgEndereco.DataSource = Cadastro.ListarEndereco();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro: " + erro);
            }
        }

      

        private void Fmrendereco_Activated(object sender, EventArgs e)
        {
            EnderecoDAO Cadastro = new EnderecoDAO();
            dgEndereco.DataSource = Cadastro.ListarEndereco();
            txt_id.Text = EnderecoModel.id;
        }

      

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                EnderecoModel obj = new EnderecoModel();
                if (txt_cep.Text == "     -") obj.cep = null;
                else obj.cep = txt_cep.Text.ToUpper();
                obj.endereco = txt_endereco.Text.ToUpper();
                obj.bairro = txt_bairro.Text.ToUpper();
                obj.numero = txt_numero.Text.ToUpper();
                obj.cidade = txt_cidade.Text.ToUpper();


                EnderecoDAO Alterar = new EnderecoDAO();

                Alterar.alterar(obj);

                dgEndereco.DataSource = Alterar.ListarEndereco();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro: " + erro);
            }

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                EnderecoModel obj = new EnderecoModel();
                obj.cep = txt_cep.Text.ToUpper();
                obj.endereco = txt_endereco.Text.ToUpper();
                obj.bairro = txt_bairro.Text.ToUpper();
                obj.numero = txt_numero.Text.ToUpper();
                obj.cidade = txt_cidade.Text.ToUpper();

                EnderecoDAO Excluir = new EnderecoDAO();

                Excluir.Excluir(obj);

                dgEndereco.DataSource = Excluir.ListarEndereco();

                EnderecoModel.id_endereco = "";
                obj.cep= "";
                obj.endereco = "";
                obj.bairro = "";
                obj.numero = "";
                obj.cidade = "";
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro: " + erro);
            }
        }

        private void dgEndereco_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string idEndereco;
            idEndereco = dgEndereco.CurrentRow.Cells[0].Value.ToString();
            txt_endereco.Text = dgEndereco.CurrentRow.Cells[1].Value.ToString();
            EnderecoModel.id_endereco = idEndereco;
            txt_numero.Text = dgEndereco.CurrentRow.Cells[2].Value.ToString();
            txt_bairro.Text = dgEndereco.CurrentRow.Cells[3].Value.ToString();
            txt_cidade.Text = dgEndereco.CurrentRow.Cells[4].Value.ToString();
            txt_cep.Text = dgEndereco.CurrentRow.Cells[5].Value.ToString();          
        }

       
        private void txt_endereco_MouseUp(object sender, MouseEventArgs e)
        {
           // PegaJson();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbxBuscar.Text != "")
                {
                    string campo = cbxBuscar.Text.ToString();
                    string finalSQL = "";

                    if (campo == "CEP") campo = "tb_endereco.cep_endereco";
                    if (campo == "RUA") campo = "tb_endereco.rua_endereco";
                    if (campo == "CIDADE") campo = "tb_endereco.cidade_endereco";
                    if (campo == "BAIRRO") campo = "tb_endereco.bairro_endereco";
                    if (campo == "NÚMERO") campo = "tb_endereco.numero_endereco";
                    finalSQL += campo.ToLower() + " like " + "'%" + txtBuscar.Text.ToString() + "%'";

                    FiltroModel.campoWhere = finalSQL;

                    dgEndereco.DataSource = Filtro.buscaEndereco();
                }
            }
            catch (Exception erro) { MessageBox.Show("Ouve um Erro " + erro.Message); }
        }

        private void cbxBuscar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_numero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }

        private void Fmrendereco_FormClosed(object sender, FormClosedEventArgs e)
        {
            EnderecoModel.id_endereco = null;
            EnderecoModel.id = null;
        }

        private void btnMostrarTudo_Click(object sender, EventArgs e)
        {
            dgEndereco.DataSource = Cadastro.ListarEndereco();
        }

        private void txt_cep_Leave(object sender, EventArgs e)
        {
            PegaJson();
        }

        private void txt_cep_Validated(object sender, EventArgs e)
        {
           
        }

        private void voltar_Click(object sender, EventArgs e)
        {
            Close();

        }
    }
}
