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
            EnderecoDAO Cadastro = new EnderecoDAO();
            dgEndereco.DataSource = Cadastro.ListarEndereco();
            txt_id.Text = EnderecoModel.id;
        }
        private void PegaJson()
        {
            try
            {
                if (txt_cep.Text != "")
                {
                   
                    HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://viacep.com.br/ws/" + txt_cep.Text + "/json/");
                    request.AllowAutoRedirect = false;

                    
                    using (HttpWebResponse ChecaServidor = (HttpWebResponse)request.GetResponse())
                    {
                        //MessageBox.Show(ChecaServidor.ToString());

                        if (ChecaServidor.StatusCode != HttpStatusCode.OK)
                        {
                            MessageBox.Show("Servidor indisponível");
                        }


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
                                            string[] valor = substring.Split(":".ToCharArray());
                                            if (valor[0] == " Erro")
                                            {
                                                MessageBox.Show("CEP não encontrado");
                                                txt_cep.Focus();

                                            }
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
                }
                else
                {
                    txt_bairro.Text = "";
                    txt_cidade.Text = "";
                    txt_endereco.Text = "";
                }
          }

            catch (Exception)
            {
                MessageBox.Show("Cep não encontrado ou servidor indisponivel");
                
                txt_bairro.Text = "";
                txt_cidade.Text = "";
                txt_endereco.Text = "";

            }

        }

   
    

   
    private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                EnderecoModel obj = new EnderecoModel();
                EnderecoModel.id = txt_id.Text;
                obj.cep = txt_cep.Text;
                obj.endereco = txt_endereco.Text;
                obj.bairro = txt_bairro.Text;
                obj.numero = txt_numero.Text;
                obj.cidade = txt_cidade.Text;


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

        private void txt_cep_Leave(object sender, EventArgs e)
        {
            PegaJson();

        }
    }
}
